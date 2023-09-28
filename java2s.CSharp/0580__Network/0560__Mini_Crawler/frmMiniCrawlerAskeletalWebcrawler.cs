using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0560__Mini_Crawler
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/MiniCrawlerAskeletalWebcrawler.htm
    public partial  class frmMiniCrawlerAskeletalWebcrawler:Form
    {
        public frmMiniCrawlerAskeletalWebcrawler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMiniCrawlerAskeletalWebcrawler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMiniCrawlerAskeletalWebcrawler";
            this.Text = "frmMiniCrawlerAskeletalWebcrawler";
            this.Load += new System.EventHandler(this.frmMiniCrawlerAskeletalWebcrawler_Load);
            this.ResumeLayout(false);

        }

        private void frmMiniCrawlerAskeletalWebcrawler_Load(object sender, EventArgs e)
        {

        }
    }
}
