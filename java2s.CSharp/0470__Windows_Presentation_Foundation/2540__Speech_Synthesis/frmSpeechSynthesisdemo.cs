using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2540__Speech_Synthesis
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SpeechSynthesisdemo.htm
    public partial  class frmSpeechSynthesisdemo:Form
    {
        public frmSpeechSynthesisdemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSpeechSynthesisdemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSpeechSynthesisdemo";
            this.Text = "frmSpeechSynthesisdemo";
            this.Load += new System.EventHandler(this.frmSpeechSynthesisdemo_Load);
            this.ResumeLayout(false);

        }

        private void frmSpeechSynthesisdemo_Load(object sender, EventArgs e)
        {

        }
    }
}
