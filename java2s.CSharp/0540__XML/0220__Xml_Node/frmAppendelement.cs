using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0220__Xml_Node
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Appendelement.htm
    public partial  class frmAppendelement:Form
    {
        public frmAppendelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAppendelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAppendelement";
            this.Text = "frmAppendelement";
            this.Load += new System.EventHandler(this.frmAppendelement_Load);
            this.ResumeLayout(false);

        }

        private void frmAppendelement_Load(object sender, EventArgs e)
        {

        }
    }
}
