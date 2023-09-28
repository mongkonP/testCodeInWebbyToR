using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0340__XPath
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/XpathDemoitemsitem.htm
    public partial  class frmXpathDemoitemsitem:Form
    {
        public frmXpathDemoitemsitem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXpathDemoitemsitem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXpathDemoitemsitem";
            this.Text = "frmXpathDemoitemsitem";
            this.Load += new System.EventHandler(this.frmXpathDemoitemsitem_Load);
            this.ResumeLayout(false);

        }

        private void frmXpathDemoitemsitem_Load(object sender, EventArgs e)
        {

        }
    }
}
