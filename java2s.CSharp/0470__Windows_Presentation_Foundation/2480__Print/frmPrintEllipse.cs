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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintEllipse.htm
    public partial  class frmPrintEllipse:Form
    {
        public frmPrintEllipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintEllipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintEllipse";
            this.Text = "frmPrintEllipse";
            this.Load += new System.EventHandler(this.frmPrintEllipse_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
