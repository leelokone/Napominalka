using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napominalka
{
    public partial class MainForm : Form
    {
        private Color darkGray = Color.FromArgb(36, 36, 36);
        private bool isDragging = false;
        private Point offset;


        public MainForm()
        {
    
            InitializeComponent();
            InitializeListView();

        }

        private void InitializeListView()
        {
     
            listViewTasks.Columns.Add("Дата", 100);     
            listViewTasks.Columns.Add("Время", 100);    
            listViewTasks.Columns.Add("Описание", -2); 

            listViewTasks.View = View.Details;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void closeProgramm_MouseMove(object sender, MouseEventArgs e)
        {
            closeProgramm.BackColor = Color.FromArgb(255, 23, 50);
            
        }

        private void closeProgramm_MouseLeave(object sender, EventArgs e)
        {
            closeProgramm.BackColor = darkGray;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            dateTimePickerAddTaskDate.MinDate = DateTime.Now;
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerAddTaskDate.Value.Date;
            DateTime selectedTime = dateTimePickerAddTaskTime.Value;
            string taskDescription = textBoxAddTask.Text;

            TaskItem newTask = new TaskItem
            {
                Date = selectedDate,
                Time = selectedTime,
                Description = taskDescription
            };


            ListViewItem item = new ListViewItem(newTask.Date.ToShortDateString());
            item.SubItems.Add(newTask.Time.ToShortTimeString());
            item.SubItems.Add(newTask.Description);
            listViewTasks.Items.Add(item);

        }

        private void buttonEditTask_Click(object sender, EventArgs e) //изменение выбранной задачи
        {
            if (listViewTasks.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = listViewTasks.SelectedItems[0];
                selectedItem.SubItems[0].Text = dateTimePickerAddTaskDate.Value.ToShortDateString();
                selectedItem.SubItems[1].Text = dateTimePickerAddTaskTime.Value.ToShortTimeString();
                selectedItem.SubItems[2].Text = textBoxAddTask.Text;
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count != 0)
            {
                listViewTasks.Items.Remove(listViewTasks.SelectedItems[0]);
            }


        }
    }
}
