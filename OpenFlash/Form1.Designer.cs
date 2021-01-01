namespace OpenFlash
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Flash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashファイルのロードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フルスクリーンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.動画ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flash
            // 
            this.Flash.Enabled = true;
            this.Flash.Location = new System.Drawing.Point(-10, 24);
            this.Flash.Margin = new System.Windows.Forms.Padding(0);
            this.Flash.Name = "Flash";
            this.Flash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flash.OcxState")));
            this.Flash.Size = new System.Drawing.Size(384, 384);
            this.Flash.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.動画ToolStripMenuItem,
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashファイルのロードToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(155, 38);
            this.ファイルToolStripMenuItem.Text = "ファイル(F)";
            // 
            // flashファイルのロードToolStripMenuItem
            // 
            this.flashファイルのロードToolStripMenuItem.Name = "flashファイルのロードToolStripMenuItem";
            this.flashファイルのロードToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.flashファイルのロードToolStripMenuItem.Text = "SWFファイルのロード";
            this.flashファイルのロードToolStripMenuItem.Click += new System.EventHandler(this.flashファイルのロードToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フルスクリーンToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(75, 38);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // フルスクリーンToolStripMenuItem
            // 
            this.フルスクリーンToolStripMenuItem.Name = "フルスクリーンToolStripMenuItem";
            this.フルスクリーンToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.フルスクリーンToolStripMenuItem.Text = "フルスクリーン";
            this.フルスクリーンToolStripMenuItem.Click += new System.EventHandler(this.フルスクリーンToolStripMenuItem_Click);
            // 
            // 動画ToolStripMenuItem
            // 
            this.動画ToolStripMenuItem.Name = "動画ToolStripMenuItem";
            this.動画ToolStripMenuItem.Size = new System.Drawing.Size(75, 38);
            this.動画ToolStripMenuItem.Text = "動画";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 649);
            this.Controls.Add(this.Flash);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash Flash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashファイルのロードToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フルスクリーンToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 動画ToolStripMenuItem;

    }
}

