using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2480__Print
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintWithoutUserIntervention.htm
    public partial  class frmPrintWithoutUserIntervention:Form
    {
        public frmPrintWithoutUserIntervention()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintWithoutUserIntervention
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintWithoutUserIntervention";
            this.Text = "frmPrintWithoutUserIntervention";
            this.Load += new System.EventHandler(this.frmPrintWithoutUserIntervention_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintWithoutUserIntervention_Load(object sender, EventArgs e)
        {

        }
    }
}
