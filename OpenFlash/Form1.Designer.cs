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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.動画ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一時停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ループ再生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最初からToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フルスクリーンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flash
            // 
            this.Flash.AllowDrop = true;
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
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.動画ToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
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
            this.flashファイルのロードToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(121, 38);
            this.ファイルToolStripMenuItem.Text = "ファイル(F)";
            // 
            // flashファイルのロードToolStripMenuItem
            // 
            this.flashファイルのロードToolStripMenuItem.Name = "flashファイルのロードToolStripMenuItem";
            this.flashファイルのロードToolStripMenuItem.Size = new System.Drawing.Size(298, 38);
            this.flashファイルのロードToolStripMenuItem.Text = "SWFファイルのロード";
            this.flashファイルのロードToolStripMenuItem.Click += new System.EventHandler(this.flashファイルのロードToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(295, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(298, 38);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 動画ToolStripMenuItem
            // 
            this.動画ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一時停止ToolStripMenuItem,
            this.ループ再生ToolStripMenuItem,
            this.最初からToolStripMenuItem});
            this.動画ToolStripMenuItem.Name = "動画ToolStripMenuItem";
            this.動画ToolStripMenuItem.Size = new System.Drawing.Size(75, 38);
            this.動画ToolStripMenuItem.Text = "動画";
            // 
            // 一時停止ToolStripMenuItem
            // 
            this.一時停止ToolStripMenuItem.Enabled = false;
            this.一時停止ToolStripMenuItem.Name = "一時停止ToolStripMenuItem";
            this.一時停止ToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.一時停止ToolStripMenuItem.Text = "一時停止";
            this.一時停止ToolStripMenuItem.Click += new System.EventHandler(this.一時停止ToolStripMenuItem_Click);
            // 
            // ループ再生ToolStripMenuItem
            // 
            this.ループ再生ToolStripMenuItem.AutoToolTip = true;
            this.ループ再生ToolStripMenuItem.Enabled = false;
            this.ループ再生ToolStripMenuItem.Name = "ループ再生ToolStripMenuItem";
            this.ループ再生ToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.ループ再生ToolStripMenuItem.Text = "ループ再生";
            this.ループ再生ToolStripMenuItem.Click += new System.EventHandler(this.ループ再生ToolStripMenuItem_Click);
            // 
            // 最初からToolStripMenuItem
            // 
            this.最初からToolStripMenuItem.Enabled = false;
            this.最初からToolStripMenuItem.Name = "最初からToolStripMenuItem";
            this.最初からToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.最初からToolStripMenuItem.Text = "最初から";
            this.最初からToolStripMenuItem.Click += new System.EventHandler(this.最初からToolStripMenuItem_Click);
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
            this.フルスクリーンToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.フルスクリーンToolStripMenuItem.Text = "フルスクリーン";
            this.フルスクリーンToolStripMenuItem.Click += new System.EventHandler(this.フルスクリーンToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // 情報ToolStripMenuItem
            // 
            this.情報ToolStripMenuItem.Name = "情報ToolStripMenuItem";
            this.情報ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.情報ToolStripMenuItem.Text = "情報";
            this.情報ToolStripMenuItem.Click += new System.EventHandler(this.情報ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 649);
            this.Controls.Add(this.Flash);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OpenFlash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
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
        private System.Windows.Forms.ToolStripMenuItem 一時停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ループ再生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最初からToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 情報ToolStripMenuItem;

    }
}

