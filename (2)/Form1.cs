using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;

namespace _2_
{
	public partial class Form1 : Form
	{
		PerformanceWork performanceWork = new();
		ProcessWork processWork = new();

		private ItemsComparer LVIComparer = null;
		private System.Timers.Timer _timer1;
		private float _cpuLoadPercentage;
		private float _memoryMBytesUsage;

		private void InitializeTimer1()
		{
			_timer1 = new System.Timers.Timer();
			_timer1.Interval = 2000;
			_timer1.Elapsed += OnTimeEvent1;
			_timer1.AutoReset = true;
			_timer1.Enabled = true;
		}
		public Form1()
		{
			InitializeComponent();
			InitializeTimer1();
		}

		//мониторит и получает информацию о процессоре и памяти
		private void OnTimeEvent1(Object source, System.Timers.ElapsedEventArgs e)
		{

			_cpuLoadPercentage = performanceWork.GetCPUValue();
			_memoryMBytesUsage = performanceWork.GetMemoryValue();

			try
			{
				toolStripStatusLabel1.Text = "Процессов: " + Process.GetProcesses().ToList<Process>().Count().ToString();
				toolStripStatusLabel2.Text = "ЦП: " + Math.Round(_cpuLoadPercentage, 1).ToString() + "%";
				toolStripStatusLabel3.Text = "Память: " + Math.Round(_memoryMBytesUsage, 1).ToString() + "%";
			}
			catch (Exception) { }
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			LVIComparer = new ItemsComparer();
			LVIComparer.ColIndex = 0;
			var allProcess = from pr in Process.GetProcesses(".")
							 select pr;
			try
			{
				foreach (var process in allProcess)
				{

					if (process.Id == 0 || process.Id == 4 || process.Id == 148)//процессы System и Idle не являются управляемыми процессами, поэтому пропускаем
					{ continue; }
					string[] row = new string[] { process.ProcessName.ToString(), process.Id.ToString(),
						Math.Round(process.PrivateMemorySize64 / (1024.0 * 1024), 1).ToString() + " MБ",
						process.Responding ? process.Responding.ToString() : process.Responding.ToString(),
						process.MainWindowHandle == IntPtr.Zero ? "Фоновый процесс" : (String.IsNullOrEmpty(process.MainWindowTitle) ? "Системный процесс" : "Приложение")
						};

					listView1.Items.Add(new ListViewItem(row));
				}
			}
			catch (Exception) { }
		}

		private void запуститьНовуюЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = Interaction.InputBox("Введите имя программы", "Запуск новой задачи");

			try
			{
				Process.Start(path);
			}

			catch (Exception) { }
			finally
			{
				processWork.RefreshProcessesList(listView1);
			}
		}

		private void завершитьПроцессToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process processToKill = processWork.getSelectedProcess(listView1); ;

			processWork.KillProcess(processToKill);

			processWork.RefreshProcessesList(listView1);
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void idleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process tmp = processWork.getSelectedProcess(listView1);
			tmp.PriorityClass = ProcessPriorityClass.Idle;
		}

		private void belowNormalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process tmp = processWork.getSelectedProcess(listView1);
			tmp.PriorityClass = ProcessPriorityClass.BelowNormal;
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process tmp = processWork.getSelectedProcess(listView1);
			tmp.PriorityClass = ProcessPriorityClass.Normal;
		}

		private void highToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process tmp = processWork.getSelectedProcess(listView1);
			tmp.PriorityClass = ProcessPriorityClass.High;
		}

		private void rEalTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process tmp = processWork.getSelectedProcess(listView1);
			tmp.PriorityClass = ProcessPriorityClass.RealTime;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			processWork.RefreshProcessesList(listView1);
		}

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			LVIComparer.ColIndex = e.Column;
			LVIComparer.SortDir = LVIComparer.SortDir == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			listView1.ListViewItemSorter = LVIComparer;
			listView1.Sort();
		}

		private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
		{

			List<Process> tmpProcesses = Process.GetProcesses().ToList();

			List<Process> filtered = tmpProcesses.Where(p => p.ProcessName.ToLower().Contains(toolStripTextBox1.Text.ToLower())).ToList();

			processWork.RefreshProcessesList(listView1, toolStripTextBox1.Text, filtered);
		}
	}
}
