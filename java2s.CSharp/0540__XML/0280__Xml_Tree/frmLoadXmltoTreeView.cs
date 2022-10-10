using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0280__Xml_Tree
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/LoadXmltoTreeView.htm
    public partial  class frmLoadXmltoTreeView:Form
    {
        public frmLoadXmltoTreeView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadXmltoTreeView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadXmltoTreeView";
            this.Text = "frmLoadXmltoTreeView";
            this.Load += new System.EventHandler(this.frmLoadXmltoTreeView_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadXmltoTreeView_Load(object sender, EventArgs e)
        {

        }
    }
}
