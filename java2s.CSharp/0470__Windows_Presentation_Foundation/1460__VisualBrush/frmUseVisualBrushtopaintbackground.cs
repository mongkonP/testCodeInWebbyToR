using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1460__VisualBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseVisualBrushtopaintbackground.htm
    public partial  class frmUseVisualBrushtopaintbackground:Form
    {
        public frmUseVisualBrushtopaintbackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseVisualBrushtopaintbackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseVisualBrushtopaintbackground";
            this.Text = "frmUseVisualBrushtopaintbackground";
            this.Load += new System.EventHandler(this.frmUseVisualBrushtopaintbackground_Load);
            this.ResumeLayout(false);

        }

        private void frmUseVisualBrushtopaintbackground_Load(object sender, EventArgs e)
        {

        }
    }
}
