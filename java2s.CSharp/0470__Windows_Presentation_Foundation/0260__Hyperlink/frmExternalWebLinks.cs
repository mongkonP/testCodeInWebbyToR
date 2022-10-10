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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ExternalWebLinks.htm
    public partial  class frmExternalWebLinks:Form
    {
        public frmExternalWebLinks()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExternalWebLinks
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExternalWebLinks";
            this.Text = "frmExternalWebLinks";
            this.Load += new System.EventHandler(this.frmExternalWebLinks_Load);
            this.ResumeLayout(false);

        }

        private void frmExternalWebLinks_Load(object sender, EventArgs e)
        {

        }
    }
}
