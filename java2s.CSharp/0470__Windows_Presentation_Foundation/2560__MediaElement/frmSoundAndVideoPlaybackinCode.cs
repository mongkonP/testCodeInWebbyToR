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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SoundAndVideoPlaybackinCode.htm
    public partial  class frmSoundAndVideoPlaybackinCode:Form
    {
        public frmSoundAndVideoPlaybackinCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSoundAndVideoPlaybackinCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSoundAndVideoPlaybackinCode";
            this.Text = "frmSoundAndVideoPlaybackinCode";
            this.Load += new System.EventHandler(this.frmSoundAndVideoPlaybackinCode_Load);
            this.ResumeLayout(false);

        }

        private void frmSoundAndVideoPlaybackinCode_Load(object sender, EventArgs e)
        {

        }
    }
}
