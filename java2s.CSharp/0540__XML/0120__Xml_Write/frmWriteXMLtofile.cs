using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0120__Xml_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/WriteXMLtofile.htm
    public partial  class frmWriteXMLtofile:Form
    {
        public frmWriteXMLtofile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriteXMLtofile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriteXMLtofile";
            this.Text = "frmWriteXMLtofile";
            this.Load += new System.EventHandler(this.frmWriteXMLtofile_Load);
            this.ResumeLayout(false);

        }

        private void frmWriteXMLtofile_Load(object sender, EventArgs e)
        {

        }
    }
}
