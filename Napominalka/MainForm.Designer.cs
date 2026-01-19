namespace Napominalka
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonDeleteTask = new Button();
            buttonEditTask = new Button();
            listViewTasks = new ListView();
            dateTimePickerAddTaskTime = new DateTimePicker();
            dateTimePickerAddTaskDate = new DateTimePicker();
            textBoxAddTask = new TextBox();
            addTask = new Button();
            topPanel = new Panel();
            progName = new Label();
            closeProgramm = new PictureBox();
            buttonSaveFile = new Button();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeProgramm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 48, 48);
            panel1.Controls.Add(buttonSaveFile);
            panel1.Controls.Add(buttonDeleteTask);
            panel1.Controls.Add(buttonEditTask);
            panel1.Controls.Add(listViewTasks);
            panel1.Controls.Add(dateTimePickerAddTaskTime);
            panel1.Controls.Add(dateTimePickerAddTaskDate);
            panel1.Controls.Add(textBoxAddTask);
            panel1.Controls.Add(addTask);
            panel1.Controls.Add(topPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 519);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.BackColor = Color.FromArgb(36, 36, 36);
            buttonDeleteTask.Cursor = Cursors.Hand;
            buttonDeleteTask.FlatAppearance.BorderSize = 0;
            buttonDeleteTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonDeleteTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonDeleteTask.FlatStyle = FlatStyle.Flat;
            buttonDeleteTask.Font = new Font("Cascadia Code SemiBold", 14F);
            buttonDeleteTask.ForeColor = Color.FromArgb(0, 150, 204);
            buttonDeleteTask.Location = new Point(175, 466);
            buttonDeleteTask.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(148, 39);
            buttonDeleteTask.TabIndex = 8;
            buttonDeleteTask.Text = "Удалить";
            buttonDeleteTask.UseVisualStyleBackColor = false;
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // buttonEditTask
            // 
            buttonEditTask.BackColor = Color.FromArgb(36, 36, 36);
            buttonEditTask.Cursor = Cursors.Hand;
            buttonEditTask.FlatAppearance.BorderSize = 0;
            buttonEditTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonEditTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonEditTask.FlatStyle = FlatStyle.Flat;
            buttonEditTask.Font = new Font("Cascadia Code SemiBold", 14F);
            buttonEditTask.ForeColor = Color.FromArgb(0, 150, 204);
            buttonEditTask.Location = new Point(20, 466);
            buttonEditTask.Margin = new Padding(4, 3, 4, 3);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(148, 39);
            buttonEditTask.TabIndex = 7;
            buttonEditTask.Text = "Изменить";
            buttonEditTask.UseVisualStyleBackColor = false;
            buttonEditTask.Click += buttonEditTask_Click;
            // 
            // listViewTasks
            // 
            listViewTasks.BorderStyle = BorderStyle.None;
            listViewTasks.Location = new Point(14, 42);
            listViewTasks.Margin = new Padding(4, 3, 4, 3);
            listViewTasks.Name = "listViewTasks";
            listViewTasks.Size = new Size(1004, 366);
            listViewTasks.TabIndex = 6;
            listViewTasks.TileSize = new Size(1680, 30);
            listViewTasks.UseCompatibleStateImageBehavior = false;
            listViewTasks.View = View.Tile;
            // 
            // dateTimePickerAddTaskTime
            // 
            dateTimePickerAddTaskTime.CustomFormat = "HH:mm";
            dateTimePickerAddTaskTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerAddTaskTime.Location = new Point(504, 421);
            dateTimePickerAddTaskTime.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerAddTaskTime.Name = "dateTimePickerAddTaskTime";
            dateTimePickerAddTaskTime.ShowUpDown = true;
            dateTimePickerAddTaskTime.Size = new Size(83, 23);
            dateTimePickerAddTaskTime.TabIndex = 5;
            // 
            // dateTimePickerAddTaskDate
            // 
            dateTimePickerAddTaskDate.Location = new Point(337, 421);
            dateTimePickerAddTaskDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerAddTaskDate.Name = "dateTimePickerAddTaskDate";
            dateTimePickerAddTaskDate.Size = new Size(159, 23);
            dateTimePickerAddTaskDate.TabIndex = 4;
            // 
            // textBoxAddTask
            // 
            textBoxAddTask.Location = new Point(337, 480);
            textBoxAddTask.Margin = new Padding(4, 3, 4, 3);
            textBoxAddTask.Name = "textBoxAddTask";
            textBoxAddTask.Size = new Size(250, 23);
            textBoxAddTask.TabIndex = 3;
            // 
            // addTask
            // 
            addTask.BackColor = Color.FromArgb(36, 36, 36);
            addTask.Cursor = Cursors.Hand;
            addTask.FlatAppearance.BorderSize = 0;
            addTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            addTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            addTask.FlatStyle = FlatStyle.Flat;
            addTask.Font = new Font("Cascadia Code SemiBold", 14F);
            addTask.ForeColor = Color.FromArgb(0, 150, 204);
            addTask.Location = new Point(20, 421);
            addTask.Margin = new Padding(4, 3, 4, 3);
            addTask.Name = "addTask";
            addTask.Size = new Size(148, 39);
            addTask.TabIndex = 1;
            addTask.Text = "Добавить";
            addTask.UseVisualStyleBackColor = false;
            addTask.Click += addTask_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(36, 36, 36);
            topPanel.Controls.Add(progName);
            topPanel.Controls.Add(closeProgramm);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4, 3, 4, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1038, 35);
            topPanel.TabIndex = 2;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // progName
            // 
            progName.BackColor = Color.Transparent;
            progName.Font = new Font("Cascadia Code SemiBold", 14F);
            progName.ForeColor = Color.FromArgb(0, 150, 204);
            progName.Location = new Point(14, 0);
            progName.Margin = new Padding(4, 0, 4, 0);
            progName.Name = "progName";
            progName.Size = new Size(172, 35);
            progName.TabIndex = 0;
            progName.Text = "Napominalka";
            progName.Click += label1_Click;
            progName.MouseDown += topPanel_MouseDown;
            progName.MouseMove += topPanel_MouseMove;
            progName.MouseUp += topPanel_MouseUp;
            // 
            // closeProgramm
            // 
            closeProgramm.BackColor = Color.FromArgb(36, 36, 36);
            closeProgramm.Cursor = Cursors.Hand;
            closeProgramm.Image = Properties.Resources.cross;
            closeProgramm.InitialImage = Properties.Resources.cross;
            closeProgramm.Location = new Point(1003, 0);
            closeProgramm.Margin = new Padding(4, 3, 4, 3);
            closeProgramm.Name = "closeProgramm";
            closeProgramm.Size = new Size(35, 35);
            closeProgramm.SizeMode = PictureBoxSizeMode.StretchImage;
            closeProgramm.TabIndex = 3;
            closeProgramm.TabStop = false;
            closeProgramm.Click += CloseProgramm_Click;
            closeProgramm.MouseLeave += closeProgramm_MouseLeave;
            closeProgramm.MouseMove += closeProgramm_MouseMove;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.BackColor = Color.FromArgb(36, 36, 36);
            buttonSaveFile.Cursor = Cursors.Hand;
            buttonSaveFile.FlatAppearance.BorderSize = 0;
            buttonSaveFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonSaveFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Font = new Font("Cascadia Code SemiBold", 14F);
            buttonSaveFile.ForeColor = Color.FromArgb(0, 150, 204);
            buttonSaveFile.Location = new Point(175, 421);
            buttonSaveFile.Margin = new Padding(4, 3, 4, 3);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(148, 39);
            buttonSaveFile.TabIndex = 9;
            buttonSaveFile.Text = "Save";
            buttonSaveFile.UseVisualStyleBackColor = false;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 519);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeProgramm).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label progName;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox closeProgramm;
        private System.Windows.Forms.TextBox textBoxAddTask;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddTaskDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddTaskTime;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private Button buttonSaveFile;
    }
}