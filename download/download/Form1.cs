using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace download
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void down_btn_video_Click(object sender, EventArgs e)
        {
            string url = progressBar.Text;
            await process.download(url, "");           
        }

        private void down_btn_audio_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            text.Text = "";            
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void progress_label_Click(object sender, EventArgs e)
        {

        }

        
    }
}
