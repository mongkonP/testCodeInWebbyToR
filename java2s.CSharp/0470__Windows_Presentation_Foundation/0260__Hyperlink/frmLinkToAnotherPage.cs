using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0260__Hyperlink
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LinkToAnotherPage.htm
    public partial  class frmLinkToAnotherPage:Form
    {
        public frmLinkToAnotherPage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinkToAnotherPage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinkToAnotherPage";
            this.Text = "frmLinkToAnotherPage";
            this.Load += new System.EventHandler(this.frmLinkToAnotherPage_Load);
            this.ResumeLayout(false);

        }

        private void frmLinkToAnotherPage_Load(object sender, EventArgs e)
        {

        }
    }
}
