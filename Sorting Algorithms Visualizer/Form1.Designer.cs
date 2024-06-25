namespace Sorting_Algorithms_Visualizer
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
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            developerToolStripMenuItem = new ToolStripMenuItem();
            repositoryToolStripMenuItem = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            comboBox = new ComboBox();
            Restart = new Button();
            label1 = new Label();
            panel1 = new Panel();
            Play = new Button();
            Pause = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, gitHubToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(978, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { developerToolStripMenuItem, repositoryToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(70, 24);
            helpToolStripMenuItem.Text = "GitHub";
            // 
            // developerToolStripMenuItem
            // 
            developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            developerToolStripMenuItem.Size = new Size(163, 26);
            developerToolStripMenuItem.Text = "Developer";
            developerToolStripMenuItem.Click += developerToolStripMenuItem_Click;
            // 
            // repositoryToolStripMenuItem
            // 
            repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            repositoryToolStripMenuItem.Size = new Size(163, 26);
            repositoryToolStripMenuItem.Text = "Repository";
            repositoryToolStripMenuItem.Click += repositoryToolStripMenuItem_Click;
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(55, 24);
            gitHubToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.White;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(378, 50);
            comboBox.Name = "comboBox";
            comboBox.RightToLeft = RightToLeft.No;
            comboBox.Size = new Size(236, 28);
            comboBox.TabIndex = 2;
            comboBox.UseWaitCursor = true;
            // 
            // Restart
            // 
            Restart.BackColor = Color.Gainsboro;
            Restart.Location = new Point(292, 462);
            Restart.Name = "Restart";
            Restart.Size = new Size(112, 29);
            Restart.TabIndex = 3;
            Restart.Text = "Reset";
            Restart.UseVisualStyleBackColor = false;
            Restart.UseWaitCursor = true;
            Restart.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 53);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Algorithm:";
            label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 337);
            panel1.TabIndex = 5;
            panel1.UseWaitCursor = true;
            // 
            // Play
            // 
            Play.BackColor = Color.Gainsboro;
            Play.Location = new Point(433, 462);
            Play.Name = "Play";
            Play.Size = new Size(112, 29);
            Play.TabIndex = 6;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = false;
            Play.UseWaitCursor = true;
            Play.Click += Play_Click;
            // 
            // Pause
            // 
            Pause.BackColor = Color.Gainsboro;
            Pause.Location = new Point(574, 462);
            Pause.Name = "Pause";
            Pause.Size = new Size(112, 29);
            Pause.TabIndex = 7;
            Pause.Text = "Pause/Resume";
            Pause.UseVisualStyleBackColor = false;
            Pause.Click += Pause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 544);
            Controls.Add(Pause);
            Controls.Add(Play);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Restart);
            Controls.Add(comboBox);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Desktop;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            UseWaitCursor = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem developerToolStripMenuItem;
        private ToolStripMenuItem repositoryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBox;
        private Button Restart;
        private Label label1;
        private Panel panel1;
        private Button Play;
        private Button Pause;
    }
}
