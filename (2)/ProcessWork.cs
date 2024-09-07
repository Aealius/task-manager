using System.Diagnostics;
using System.Management;
using System.Reflection.Metadata.Ecma335;

namespace _2_
{
    internal class ProcessWork
    {
        private List<Process> processList;

        public void GetProcessList()
        {
            processList = Process.GetProcesses().ToList<Process>();
        }

        public void RefreshProcessesList(ListView lvw)
        {
            lvw.Items.Clear();
            try
            {
                foreach (var process in Process.GetProcesses())
                {

                    if (process.Id == 0 || process.Id == 4)//процессы System и Idle не являются управляемыми процессами, поэтому пропускаем
                    { continue; }
                    string[] row = new string[] { process.ProcessName.ToString(), process.Id.ToString(),
                        Math.Round(process.WorkingSet64 / (1024.0 * 1024), 1).ToString() + " MБ",
                        process.Responding ? "Выполняется" : "Не отвечает",
                        process.MainWindowHandle == IntPtr.Zero ? "Фоновый процесс" : (String.IsNullOrEmpty(process.MainWindowTitle) ? "Системный процесс" : "Приложение")};
                    lvw.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception) { }
        }

        public void RefreshProcessesList(ListView lvw, string keyword, List<Process> processes)
        {
            lvw.Items.Clear();
            try
            {
                foreach (var process in processes)
                {

                    if (process.Id == 0 || process.Id == 4)//процессы System и Idle не являются управляемыми процессами, поэтому пропускаем
                    { continue; }
                    string[] row = new string[] { process.ProcessName.ToString(), process.Id.ToString(),
                        Math.Round(process.WorkingSet64 / (1024.0 * 1024), 1).ToString() + " MБ",
                        process.Responding ? "Выполняется" : "Не отвечает",
                        process.MainWindowHandle == IntPtr.Zero ? "Фоновый процесс" : (String.IsNullOrEmpty(process.MainWindowTitle) ? "Системный процесс" : "Приложение")};
                    lvw.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception) { }
        }

        public Process getSelectedProcess(ListView listView)
        {
            GetProcessList();
            int index = 0;
            foreach (Process p in processList)
            {
                if (p.Id == Int16.Parse(listView.SelectedItems[0].SubItems[1].Text))
                {
                    index = processList.ToList().IndexOf(p);
                    break;
                }
            }
            return processList[index];
        }

        public void KillProcess(Process process)
        {
            process.Kill();

            process.WaitForExit();
        }
    }
}
