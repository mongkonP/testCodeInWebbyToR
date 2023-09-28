using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0040__XElement
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/GetDescendantsforanode.htm
    public partial  class frmGetDescendantsforanode:Form
    {
        public frmGetDescendantsforanode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDescendantsforanode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDescendantsforanode";
            this.Text = "frmGetDescendantsforanode";
            this.Load += new System.EventHandler(this.frmGetDescendantsforanode_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDescendantsforanode_Load(object sender, EventArgs e)
        {

        }
    }
}
