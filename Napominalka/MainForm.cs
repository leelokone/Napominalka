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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
