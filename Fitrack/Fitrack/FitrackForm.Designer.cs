
namespace Fitrack
{
    partial class FitrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitrackForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.titleBarIcon = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.Panel();
            this.progressTrackerButton = new System.Windows.Forms.Button();
            this.workoutTrackerButton = new System.Windows.Forms.Button();
            this.nutritionTrackerButton = new System.Windows.Forms.Button();
            this.minimizeButton = new Fitrack.TitleBarButton();
            this.closeButton = new Fitrack.TitleBarButton();
            this.animationTimer = new Fitrack.AnimationTimer();
            this.weightTrackerButton = new System.Windows.Forms.Button();
            this.sleepTrackerButton = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleBarIcon)).BeginInit();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titleBar.Controls.Add(this.minimizeButton);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Controls.Add(this.titleBarIcon);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(4);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1067, 31);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // titleBarIcon
            // 
            this.titleBarIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleBarIcon.Location = new System.Drawing.Point(0, 0);
            this.titleBarIcon.Margin = new System.Windows.Forms.Padding(4);
            this.titleBarIcon.Name = "titleBarIcon";
            this.titleBarIcon.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.titleBarIcon.Size = new System.Drawing.Size(33, 31);
            this.titleBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleBarIcon.TabIndex = 0;
            this.titleBarIcon.TabStop = false;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuBar.Controls.Add(this.sleepTrackerButton);
            this.menuBar.Controls.Add(this.weightTrackerButton);
            this.menuBar.Controls.Add(this.nutritionTrackerButton);
            this.menuBar.Controls.Add(this.progressTrackerButton);
            this.menuBar.Controls.Add(this.workoutTrackerButton);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Location = new System.Drawing.Point(0, 31);
            this.menuBar.Margin = new System.Windows.Forms.Padding(4);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(100, 584);
            this.menuBar.TabIndex = 1;
            // 
            // progressTrackerButton
            // 
            this.progressTrackerButton.Location = new System.Drawing.Point(12, 144);
            this.progressTrackerButton.Name = "progressTrackerButton";
            this.progressTrackerButton.Size = new System.Drawing.Size(75, 61);
            this.progressTrackerButton.TabIndex = 3;
            this.progressTrackerButton.Text = "Progress Tracker";
            this.progressTrackerButton.UseVisualStyleBackColor = true;
            this.progressTrackerButton.Click += new System.EventHandler(this.progressTrackerButton_Click);
            // 
            // workoutTrackerButton
            // 
            this.workoutTrackerButton.Location = new System.Drawing.Point(12, 52);
            this.workoutTrackerButton.Name = "workoutTrackerButton";
            this.workoutTrackerButton.Size = new System.Drawing.Size(75, 63);
            this.workoutTrackerButton.TabIndex = 2;
            this.workoutTrackerButton.Text = "Workout Tracker";
            this.workoutTrackerButton.UseVisualStyleBackColor = true;
            this.workoutTrackerButton.Click += new System.EventHandler(this.workoutTrackerButton_Click);
            // 
            // nutritionTrackerButton
            // 
            this.nutritionTrackerButton.Location = new System.Drawing.Point(12, 233);
            this.nutritionTrackerButton.Name = "nutritionTrackerButton";
            this.nutritionTrackerButton.Size = new System.Drawing.Size(75, 61);
            this.nutritionTrackerButton.TabIndex = 3;
            this.nutritionTrackerButton.Text = "Nutrition Tracker";
            this.nutritionTrackerButton.UseVisualStyleBackColor = true;
            this.nutritionTrackerButton.Click += new System.EventHandler(this.nutritionTrackerButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.HoverColor = System.Drawing.Color.Green;
            this.minimizeButton.HoverImage = null;
            this.minimizeButton.Location = new System.Drawing.Point(1001, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.minimizeButton.Size = new System.Drawing.Size(33, 31);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UnhoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimizeButton.UnhoverImage = null;
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.HoverColor = System.Drawing.Color.Red;
            this.closeButton.HoverImage = null;
            this.closeButton.Location = new System.Drawing.Point(1034, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.closeButton.Size = new System.Drawing.Size(33, 31);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.UnhoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.closeButton.UnhoverImage = null;
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseUp);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // weightTrackerButton
            // 
            this.weightTrackerButton.Location = new System.Drawing.Point(12, 321);
            this.weightTrackerButton.Name = "weightTrackerButton";
            this.weightTrackerButton.Size = new System.Drawing.Size(75, 57);
            this.weightTrackerButton.TabIndex = 3;
            this.weightTrackerButton.Text = "Weight Tracker";
            this.weightTrackerButton.UseVisualStyleBackColor = true;
            this.weightTrackerButton.Click += new System.EventHandler(this.weightTrackerButton_Click);
            // 
            // sleepTrackerButton
            // 
            this.sleepTrackerButton.Location = new System.Drawing.Point(12, 405);
            this.sleepTrackerButton.Name = "sleepTrackerButton";
            this.sleepTrackerButton.Size = new System.Drawing.Size(75, 57);
            this.sleepTrackerButton.TabIndex = 4;
            this.sleepTrackerButton.Text = "Sleep Tracker";
            this.sleepTrackerButton.UseVisualStyleBackColor = true;
            this.sleepTrackerButton.Click += new System.EventHandler(this.sleepTrackerButton_Click);
            // 
            // FitrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FitrackForm";
            this.Text = "Fitrack";
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleBarIcon)).EndInit();
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox titleBarIcon;
        private AnimationTimer animationTimer;
        private TitleBarButton minimizeButton;
        private TitleBarButton closeButton;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button workoutTrackerButton;
        private System.Windows.Forms.Button progressTrackerButton;
        private System.Windows.Forms.Button nutritionTrackerButton;
        private System.Windows.Forms.Button sleepTrackerButton;
        private System.Windows.Forms.Button weightTrackerButton;
    }
}

