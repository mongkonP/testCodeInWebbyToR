using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2560__MediaElement
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PlaywithMediaPlayer.htm
    public partial  class frmPlaywithMediaPlayer:Form
    {
        public frmPlaywithMediaPlayer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlaywithMediaPlayer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlaywithMediaPlayer";
            this.Text = "frmPlaywithMediaPlayer";
            this.Load += new System.EventHandler(this.frmPlaywithMediaPlayer_Load);
            this.ResumeLayout(false);

        }

        private void frmPlaywithMediaPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
