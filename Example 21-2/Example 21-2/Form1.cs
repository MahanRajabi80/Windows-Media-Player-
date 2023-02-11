using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_21_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------
        string playFile = "";
        //------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.settings.mute = false;
            axWindowsMediaPlayer1.settings.volume = int.MaxValue;
        }
        //------------------------------------------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Filter = "MP3 Files(*.mp3)|*.mp3|Sound Files(*.wav)|*.wav|MPEG Files(*.mpeg)|*.mpeg|All Files(*.*)|*.*";
            DialogResult d = openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && d != DialogResult.Cancel)
                playFile = openFileDialog1.FileName;
            else
                return;
            try
            {
                axWindowsMediaPlayer1.URL = playFile;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
