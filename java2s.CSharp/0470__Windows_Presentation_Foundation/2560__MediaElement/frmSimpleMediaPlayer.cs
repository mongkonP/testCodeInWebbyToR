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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SimpleMediaPlayer.htm
    public partial  class frmSimpleMediaPlayer:Form
    {
        public frmSimpleMediaPlayer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleMediaPlayer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleMediaPlayer";
            this.Text = "frmSimpleMediaPlayer";
            this.Load += new System.EventHandler(this.frmSimpleMediaPlayer_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleMediaPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
