using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OpenFlash
{
    public partial class Form1 : Form
    {
        static string swfPath;
        public Form1()
        {
            InitializeComponent();
            this.Flash.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height-63);
            Console.WriteLine("Started");
            this.Resize += new EventHandler(Form1_Resize);
            string[] cmds = System.Environment.GetCommandLineArgs();
            if (cmds.Length != 0)
            {
                Flash.LoadMovie(0, cmds[1]);
            }
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            this.Flash.Size = new System.Drawing.Size(control.Width, control.Height-63);
        }


        private void flashファイルのロードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                swfPath = openFileDialog1.FileName;
                Flash.LoadMovie(0, swfPath);
            }
        }

        private void フルスクリーンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (this.FormBorderStyle == FormBorderStyle.Sizable && this.WindowState == FormWindowState.Normal)
            {
                item.Checked = true;
                this.フルスクリーンToolStripMenuItem.Text = "通常表示";
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Flash.Size = new System.Drawing.Size(this.Size.Width+10, this.Size.Height-20);
            }
            else
            {
                item.Checked = false;
                this.フルスクリーンToolStripMenuItem.Text = "フルスクリーン";
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void 一時停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Flash.Playing == true)
            {
                Flash.StopPlay();
                this.一時停止ToolStripMenuItem.Text = "再生";
            }
            else
            {
                Flash.Play();
                this.一時停止ToolStripMenuItem.Text = "一時停止";
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ループ再生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            Flash.Loop = item.Checked;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string file = string.Empty; // テキストボックスを空にする。
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); // ドロップされたものがFileDrop形式の場合は、各ファイルのパス文字列を文字列配列に格納する。
            if (files != null)
            {
                foreach (string uriString in files)
                {
                    file = file + uriString; // パス文字列からファイル名を抜き出して、テキストボックスにファイル名を書き込む。
                }
            }
            Flash.LoadMovie(0, file);
        }

    }
}
