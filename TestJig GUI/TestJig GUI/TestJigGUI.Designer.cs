namespace TestJig_GUI
{
    partial class TJmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tStatus = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.tAbout = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmEdit,
            this.mmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fmOpen,
            this.fmSave,
            this.fmExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(37, 20);
            this.mmFile.Text = "File";
            // 
            // fmOpen
            // 
            this.fmOpen.Name = "fmOpen";
            this.fmOpen.Size = new System.Drawing.Size(180, 22);
            this.fmOpen.Text = "Open";
            this.fmOpen.Click += new System.EventHandler(this.fmOpen_Click);
            // 
            // fmSave
            // 
            this.fmSave.Name = "fmSave";
            this.fmSave.Size = new System.Drawing.Size(180, 22);
            this.fmSave.Text = "Save";
            this.fmSave.Click += new System.EventHandler(this.fmSave_Click);
            // 
            // fmExit
            // 
            this.fmExit.Name = "fmExit";
            this.fmExit.Size = new System.Drawing.Size(180, 22);
            this.fmExit.Text = "Exit";
            this.fmExit.Click += new System.EventHandler(this.fmExit_Click);
            // 
            // mmEdit
            // 
            this.mmEdit.Name = "mmEdit";
            this.mmEdit.Size = new System.Drawing.Size(39, 20);
            this.mmEdit.Text = "Edit";
            // 
            // mmAbout
            // 
            this.mmAbout.Name = "mmAbout";
            this.mmAbout.Size = new System.Drawing.Size(52, 20);
            this.mmAbout.Text = "About";
            this.mmAbout.Click += new System.EventHandler(this.mmAbout_Click);
            // 
            // tStatus
            // 
            this.tStatus.Location = new System.Drawing.Point(33, 348);
            this.tStatus.Multiline = true;
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(522, 98);
            this.tStatus.TabIndex = 1;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(36, 329);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(73, 25);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Status";
            // 
            // tAbout
            // 
            this.tAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAbout.Location = new System.Drawing.Point(33, 67);
            this.tAbout.Multiline = true;
            this.tAbout.Name = "tAbout";
            this.tAbout.Size = new System.Drawing.Size(521, 165);
            this.tAbout.TabIndex = 3;
            // 
            // TJmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tAbout);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.tStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TJmenu";
            this.Text = "Test Jig GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mmEdit;
        private System.Windows.Forms.ToolStripMenuItem mmAbout;
        private System.Windows.Forms.ToolStripMenuItem fmOpen;
        private System.Windows.Forms.ToolStripMenuItem fmSave;
        private System.Windows.Forms.ToolStripMenuItem fmExit;
        private System.Windows.Forms.TextBox tStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tAbout;
    }
}

