using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0470__Xml_DataTable
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/UsingDataTabletoreadXml.htm
    public partial  class frmUsingDataTabletoreadXml:Form
    {
        public frmUsingDataTabletoreadXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingDataTabletoreadXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingDataTabletoreadXml";
            this.Text = "frmUsingDataTabletoreadXml";
            this.Load += new System.EventHandler(this.frmUsingDataTabletoreadXml_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingDataTabletoreadXml_Load(object sender, EventArgs e)
        {

        }
    }
}
