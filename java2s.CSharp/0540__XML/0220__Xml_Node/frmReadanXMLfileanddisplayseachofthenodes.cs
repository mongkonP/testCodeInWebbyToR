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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadanXMLfileanddisplayseachofthenodes.htm
    public partial  class frmReadanXMLfileanddisplayseachofthenodes:Form
    {
        public frmReadanXMLfileanddisplayseachofthenodes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadanXMLfileanddisplayseachofthenodes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadanXMLfileanddisplayseachofthenodes";
            this.Text = "frmReadanXMLfileanddisplayseachofthenodes";
            this.Load += new System.EventHandler(this.frmReadanXMLfileanddisplayseachofthenodes_Load);
            this.ResumeLayout(false);

        }

        private void frmReadanXMLfileanddisplayseachofthenodes_Load(object sender, EventArgs e)
        {

        }
    }
}
