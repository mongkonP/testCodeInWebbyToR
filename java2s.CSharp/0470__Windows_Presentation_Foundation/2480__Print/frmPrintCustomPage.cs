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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PrintCustomPage.htm
    public partial  class frmPrintCustomPage:Form
    {
        public frmPrintCustomPage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintCustomPage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintCustomPage";
            this.Text = "frmPrintCustomPage";
            this.Load += new System.EventHandler(this.frmPrintCustomPage_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintCustomPage_Load(object sender, EventArgs e)
        {

        }
    }
}
