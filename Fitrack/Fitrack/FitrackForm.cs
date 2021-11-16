using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitrack
{
    public partial class FitrackForm : Form
    {
        public FitrackForm()
        {
            InitializeComponent();

            /* Set Title Bar Icon Image */
            titleBarIcon.Image = Properties.Resources.Fitrack;
            closeButton.Image = Properties.Resources.Close;
            minimizeButton.Image = Properties.Resources.Minimize;
        }

        /* Custom Title Bar */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void minimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            animationTimer.currentButton = minimizeButton;
            animationTimer.startColor = minimizeButton.UnhoverColor;
            animationTimer.targetColor = minimizeButton.HoverColor;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            animationTimer.Reset();
            minimizeButton.BackColor = minimizeButton.UnhoverColor;
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            animationTimer.currentButton = closeButton;
            animationTimer.startColor = closeButton.UnhoverColor;
            animationTimer.targetColor = closeButton.HoverColor;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            animationTimer.Reset();
            closeButton.BackColor = closeButton.UnhoverColor;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Animate();
        }

        //make a function to remove repeated code, for now is placeholder code, same for the buttons on the main form

        private void workoutTrackerButton_Click(object sender, EventArgs e)
        {
            WorkoutTrackerForm newMDIChild = new WorkoutTrackerForm();

            newMDIChild.MdiParent = this;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Show();
        }

        private void progressTrackerButton_Click(object sender, EventArgs e)
        {
            ProgressTrackerForm newMDIChild = new ProgressTrackerForm();

            newMDIChild.MdiParent = this;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Show();
        }

        private void nutritionTrackerButton_Click(object sender, EventArgs e)
        {
            NutritionTrackerForm newMDIChild = new NutritionTrackerForm();
            newMDIChild.MdiParent = this;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Show();
        }

        private void weightTrackerButton_Click(object sender, EventArgs e)
        {
            WeightTrackerForm newMDIChild = new WeightTrackerForm();
            newMDIChild.MdiParent = this;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Show();
        }

        private void sleepTrackerButton_Click(object sender, EventArgs e)
        {
            SleepTrackerForm newMDIChild = new SleepTrackerForm();
            newMDIChild.MdiParent = this;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Show();
        }
    }
}
