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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/PlaythesoundassociatedwiththeAsteriskevent.htm
    public partial  class frmPlaythesoundassociatedwiththeAsteriskevent:Form
    {
        public frmPlaythesoundassociatedwiththeAsteriskevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlaythesoundassociatedwiththeAsteriskevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlaythesoundassociatedwiththeAsteriskevent";
            this.Text = "frmPlaythesoundassociatedwiththeAsteriskevent";
            this.Load += new System.EventHandler(this.frmPlaythesoundassociatedwiththeAsteriskevent_Load);
            this.ResumeLayout(false);

        }

        private void frmPlaythesoundassociatedwiththeAsteriskevent_Load(object sender, EventArgs e)
        {

        }
    }
}
