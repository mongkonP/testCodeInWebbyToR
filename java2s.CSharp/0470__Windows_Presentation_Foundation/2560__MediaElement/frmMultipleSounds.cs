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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MultipleSounds.htm
    public partial  class frmMultipleSounds:Form
    {
        public frmMultipleSounds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultipleSounds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultipleSounds";
            this.Text = "frmMultipleSounds";
            this.Load += new System.EventHandler(this.frmMultipleSounds_Load);
            this.ResumeLayout(false);

        }

        private void frmMultipleSounds_Load(object sender, EventArgs e)
        {

        }
    }
}
