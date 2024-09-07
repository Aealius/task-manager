namespace _2_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			menuStrip1 = new MenuStrip();
			файлToolStripMenuItem = new ToolStripMenuItem();
			запуститьНовуюЗадачуToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripLabel1 = new ToolStripLabel();
			toolStripTextBox1 = new ToolStripTextBox();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1582, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { запуститьНовуюЗадачуToolStripMenuItem, выходToolStripMenuItem });
			файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			файлToolStripMenuItem.Size = new Size(59, 24);
			файлToolStripMenuItem.Text = "Файл";
			// 
			// запуститьНовуюЗадачуToolStripMenuItem
			// 
			запуститьНовуюЗадачуToolStripMenuItem.Name = "запуститьНовуюЗадачуToolStripMenuItem";
			запуститьНовуюЗадачуToolStripMenuItem.Size = new Size(259, 26);
			запуститьНовуюЗадачуToolStripMenuItem.Text = "Запустить новую задачу";
			запуститьНовуюЗадачуToolStripMenuItem.Click += запуститьНовуюЗадачуToolStripMenuItem_Click;
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(259, 26);
			выходToolStripMenuItem.Text = "Выход";
			выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
			statusStrip1.Location = new Point(0, 827);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1582, 26);
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(93, 20);
			toolStripStatusLabel1.Text = "Процессов: ";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(43, 20);
			toolStripStatusLabel2.Text = "CPU: ";
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(68, 20);
			toolStripStatusLabel3.Text = "Память: ";
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripTextBox1 });
			toolStrip1.Location = new Point(0, 28);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1582, 27);
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = Properties.Resources.icons8_update_left_rotation_50;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(29, 24);
			toolStripButton1.Text = "Обновить";
			toolStripButton1.Click += toolStripButton1_Click;
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Size = new Size(63, 24);
			toolStripLabel1.Text = "Фильтр:";
			// 
			// toolStripTextBox1
			// 
			toolStripTextBox1.Name = "toolStripTextBox1";
			toolStripTextBox1.Size = new Size(100, 27);
			toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
			listView1.Dock = DockStyle.Fill;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(0, 55);
			listView1.Name = "listView1";
			listView1.Size = new Size(1582, 772);
			listView1.TabIndex = 4;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.ColumnClick += listView1_ColumnClick;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Имя";
			columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "ID";
			columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Память";
			columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Статус";
			columnHeader4.Width = 170;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Тип";
			columnHeader5.Width = 200;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1582, 853);
			Controls.Add(listView1);
			Controls.Add(toolStrip1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Диспетчер задач";
			Load += Form1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem запуститьНовуюЗадачуToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
    }
}