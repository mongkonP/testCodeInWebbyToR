using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2580__SoundPlayerAction
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SoundPlayerActiondemo.htm
    public partial  class frmSoundPlayerActiondemo:Form
    {
        public frmSoundPlayerActiondemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSoundPlayerActiondemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSoundPlayerActiondemo";
            this.Text = "frmSoundPlayerActiondemo";
            this.Load += new System.EventHandler(this.frmSoundPlayerActiondemo_Load);
            this.ResumeLayout(false);

        }

        private void frmSoundPlayerActiondemo_Load(object sender, EventArgs e)
        {

        }
    }
}
