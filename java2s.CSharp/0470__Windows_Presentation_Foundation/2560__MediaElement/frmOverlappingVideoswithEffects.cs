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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OverlappingVideoswithEffects.htm
    public partial  class frmOverlappingVideoswithEffects:Form
    {
        public frmOverlappingVideoswithEffects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverlappingVideoswithEffects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverlappingVideoswithEffects";
            this.Text = "frmOverlappingVideoswithEffects";
            this.Load += new System.EventHandler(this.frmOverlappingVideoswithEffects_Load);
            this.ResumeLayout(false);

        }

        private void frmOverlappingVideoswithEffects_Load(object sender, EventArgs e)
        {

        }
    }
}
