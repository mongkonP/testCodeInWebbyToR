using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0100__XmlReader
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XmlTextReaderinAction.htm
    public partial  class frmXmlTextReaderinAction:Form
    {
        public frmXmlTextReaderinAction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXmlTextReaderinAction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXmlTextReaderinAction";
            this.Text = "frmXmlTextReaderinAction";
            this.Load += new System.EventHandler(this.frmXmlTextReaderinAction_Load);
            this.ResumeLayout(false);

        }

        private void frmXmlTextReaderinAction_Load(object sender, EventArgs e)
        {

        }
    }
}
