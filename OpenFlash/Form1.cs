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
        static string swfPath = string.Empty;
        static bool playing = false;
        public void PlayFlash(string file, int bootflag = 0)
        {
            if (System.IO.Path.GetExtension(file) == ".swf")
            {
                if (playing==true)
                {
                    DialogResult result = MessageBox.Show("再生中の動画を停止し新しい動画を再生しますか？",
                    "質問",
                    MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Flash.LoadMovie(0, file);
                        playing = true;
                    }
                }
                else
                {
                    Flash.LoadMovie(0, file);
                    playing = true;
                }
                this.一時停止ToolStripMenuItem.Enabled = playing;
                this.ループ再生ToolStripMenuItem.Enabled = playing;
                this.最初からToolStripMenuItem.Enabled = playing;
            }else{
                DialogResult result = MessageBox.Show("SWF形式のファイルではありません。",
                    "エラー",
                    MessageBoxButtons.OK);
                    if (bootflag == 1)
                    {
                        Environment.Exit(0);
                    }
            }
        }
        public Form1()
        {
            this.Size = new System.Drawing.Size(720, 480);
            InitializeComponent();
            this.Flash.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height-63);
            this.Resize += new EventHandler(Form1_Resize);
            string[] cmds = System.Environment.GetCommandLineArgs();
            if (cmds.Length == 2)
            {
                swfPath = cmds[1];
                PlayFlash(swfPath, 1);
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
                PlayFlash(swfPath);
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
                playing = false;
            }
            else
            {
                Flash.Play();
                this.一時停止ToolStripMenuItem.Text = "一時停止";
                playing = true;
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playing == true && swfPath != string.Empty)
            {
                DialogResult result = MessageBox.Show("再生中の動画を停止し終了しますか？",
                "質問",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Flash.Stop();
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ループ再生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            Flash.Loop = item.Checked;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string file = string.Empty;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null)
            {
                foreach (string uriString in files)
                {
                    file = file + uriString;
                }
            }
            swfPath = file;
            PlayFlash(swfPath);
        }

        private void 最初からToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flash.Rewind();
            Flash.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playing == true && swfPath != string.Empty)
            {
                DialogResult result = MessageBox.Show("再生中の動画を停止し終了しますか？",
                "質問",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void 情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abForm = new AboutBox1();
            abForm.ShowDialog();
        }

    }
}

/*
    #koishi_doujin {
        content:"HelloWorld! <br /> thanks for find! <br /> Quote from 物凄いスペースシャトルでこいしが物凄いうた";
    }
*/