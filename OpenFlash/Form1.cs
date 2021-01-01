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
        public Form1()
        {
            InitializeComponent();
            //String swfPath = "C:\\Users\\FURCHT FUTURR\\Documents\\魔理沙は大変なものを盗んでいきました.swf";
            //Flash.LoadMovie(0, swfPath);
            this.Flash.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height-63);
            Console.WriteLine("Started");
            this.Resize += new EventHandler(Form1_Resize);
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            this.Flash.Size = new System.Drawing.Size(control.Width, control.Height-63);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void flashファイルのロードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Flash.LoadMovie(0, openFileDialog1.FileName);
            }
        }

        private void フルスクリーンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable && this.WindowState == FormWindowState.Normal)
            {
                this.フルスクリーンToolStripMenuItem.Text = "通常表示";
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Flash.Size = new System.Drawing.Size(this.Size.Width+10, this.Size.Height);
            }
            else
            {
                this.フルスクリーンToolStripMenuItem.Text = "フルスクリーン";
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

    }
}
