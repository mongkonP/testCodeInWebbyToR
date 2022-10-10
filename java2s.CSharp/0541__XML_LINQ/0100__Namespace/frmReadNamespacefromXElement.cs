using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/ReadNamespacefromXElement.htm
    public partial  class frmReadNamespacefromXElement:Form
    {
        public frmReadNamespacefromXElement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadNamespacefromXElement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadNamespacefromXElement";
            this.Text = "frmReadNamespacefromXElement";
            this.Load += new System.EventHandler(this.frmReadNamespacefromXElement_Load);
            this.ResumeLayout(false);

        }

        private void frmReadNamespacefromXElement_Load(object sender, EventArgs e)
        {

        }
    }
}
