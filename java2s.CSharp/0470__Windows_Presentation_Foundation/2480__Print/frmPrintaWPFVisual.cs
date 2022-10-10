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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintaWPFVisual.htm
    public partial  class frmPrintaWPFVisual:Form
    {
        public frmPrintaWPFVisual()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintaWPFVisual
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintaWPFVisual";
            this.Text = "frmPrintaWPFVisual";
            this.Load += new System.EventHandler(this.frmPrintaWPFVisual_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintaWPFVisual_Load(object sender, EventArgs e)
        {

        }
    }
}
