using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0380__XmlPathNavigator
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XPathNavigatorEvaluate.htm
    public partial  class frmXPathNavigatorEvaluate:Form
    {
        public frmXPathNavigatorEvaluate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXPathNavigatorEvaluate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXPathNavigatorEvaluate";
            this.Text = "frmXPathNavigatorEvaluate";
            this.Load += new System.EventHandler(this.frmXPathNavigatorEvaluate_Load);
            this.ResumeLayout(false);

        }

        private void frmXPathNavigatorEvaluate_Load(object sender, EventArgs e)
        {

        }
    }
}
