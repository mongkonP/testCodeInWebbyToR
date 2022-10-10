using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0680__SoundPlayer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/PlayawavfilebyusingSoundPlayer.htm
    public partial  class frmPlayawavfilebyusingSoundPlayer:Form
    {
        public frmPlayawavfilebyusingSoundPlayer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlayawavfilebyusingSoundPlayer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlayawavfilebyusingSoundPlayer";
            this.Text = "frmPlayawavfilebyusingSoundPlayer";
            this.Load += new System.EventHandler(this.frmPlayawavfilebyusingSoundPlayer_Load);
            this.ResumeLayout(false);

        }

        private void frmPlayawavfilebyusingSoundPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
