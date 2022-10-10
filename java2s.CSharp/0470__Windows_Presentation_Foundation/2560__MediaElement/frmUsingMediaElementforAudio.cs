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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingMediaElementforAudio.htm
    public partial  class frmUsingMediaElementforAudio:Form
    {
        public frmUsingMediaElementforAudio()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingMediaElementforAudio
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingMediaElementforAudio";
            this.Text = "frmUsingMediaElementforAudio";
            this.Load += new System.EventHandler(this.frmUsingMediaElementforAudio_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingMediaElementforAudio_Load(object sender, EventArgs e)
        {

        }
    }
}
