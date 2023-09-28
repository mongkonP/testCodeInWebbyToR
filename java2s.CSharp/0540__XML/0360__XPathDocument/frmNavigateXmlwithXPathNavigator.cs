using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0360__XPathDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/NavigateXmlwithXPathNavigator.htm
    public partial  class frmNavigateXmlwithXPathNavigator:Form
    {
        public frmNavigateXmlwithXPathNavigator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigateXmlwithXPathNavigator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigateXmlwithXPathNavigator";
            this.Text = "frmNavigateXmlwithXPathNavigator";
            this.Load += new System.EventHandler(this.frmNavigateXmlwithXPathNavigator_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigateXmlwithXPathNavigator_Load(object sender, EventArgs e)
        {

        }
    }
}
