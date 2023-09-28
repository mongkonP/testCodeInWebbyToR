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
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/Removeanelement.htm
    public partial  class frmRemoveanelement:Form
    {
        public frmRemoveanelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveanelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveanelement";
            this.Text = "frmRemoveanelement";
            this.Load += new System.EventHandler(this.frmRemoveanelement_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveanelement_Load(object sender, EventArgs e)
        {

        }
    }
}
