using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0240__Xml_Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectNodesByNamespace.htm
    public partial  class frmSelectNodesByNamespace:Form
    {
        public frmSelectNodesByNamespace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectNodesByNamespace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectNodesByNamespace";
            this.Text = "frmSelectNodesByNamespace";
            this.Load += new System.EventHandler(this.frmSelectNodesByNamespace_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectNodesByNamespace_Load(object sender, EventArgs e)
        {

        }
    }
}
