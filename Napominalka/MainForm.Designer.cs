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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTask = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.progName = new System.Windows.Forms.Label();
            this.closeProgramm = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeProgramm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.addTask);
            this.panel1.Controls.Add(this.topPanel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 3;
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F);
            this.addTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(204)))));
            this.addTask.Location = new System.Drawing.Point(17, 374);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(127, 64);
            this.addTask.TabIndex = 1;
            this.addTask.Text = "Добавить";
            this.addTask.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.topPanel.Controls.Add(this.progName);
            this.topPanel.Controls.Add(this.closeProgramm);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(890, 30);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // progName
            // 
            this.progName.BackColor = System.Drawing.Color.Transparent;
            this.progName.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F);
            this.progName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(204)))));
            this.progName.Location = new System.Drawing.Point(12, 0);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(147, 30);
            this.progName.TabIndex = 0;
            this.progName.Text = "Napominalka";
            this.progName.Click += new System.EventHandler(this.label1_Click);
            this.progName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.progName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.progName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // closeProgramm
            // 
            this.closeProgramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.closeProgramm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProgramm.Image = global::Napominalka.Properties.Resources.cross;
            this.closeProgramm.Location = new System.Drawing.Point(860, 0);
            this.closeProgramm.Name = "closeProgramm";
            this.closeProgramm.Size = new System.Drawing.Size(30, 30);
            this.closeProgramm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeProgramm.TabIndex = 3;
            this.closeProgramm.TabStop = false;
            this.closeProgramm.Click += new System.EventHandler(this.CloseProgramm_Click);
            this.closeProgramm.MouseLeave += new System.EventHandler(this.closeProgramm_MouseLeave);
            this.closeProgramm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closeProgramm_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeProgramm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label progName;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox closeProgramm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}