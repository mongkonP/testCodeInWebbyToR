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
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/DealwithWhiteSpaces.htm
    public partial  class frmDealwithWhiteSpaces:Form
    {
        public frmDealwithWhiteSpaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDealwithWhiteSpaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDealwithWhiteSpaces";
            this.Text = "frmDealwithWhiteSpaces";
            this.Load += new System.EventHandler(this.frmDealwithWhiteSpaces_Load);
            this.ResumeLayout(false);

        }

        private void frmDealwithWhiteSpaces_Load(object sender, EventArgs e)
        {

        }
    }
}
