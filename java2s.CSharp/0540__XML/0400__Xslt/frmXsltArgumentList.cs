using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0400__Xslt
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XsltArgumentList.htm
    public partial  class frmXsltArgumentList:Form
    {
        public frmXsltArgumentList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXsltArgumentList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXsltArgumentList";
            this.Text = "frmXsltArgumentList";
            this.Load += new System.EventHandler(this.frmXsltArgumentList_Load);
            this.ResumeLayout(false);

        }

        private void frmXsltArgumentList_Load(object sender, EventArgs e)
        {

        }
    }
}
