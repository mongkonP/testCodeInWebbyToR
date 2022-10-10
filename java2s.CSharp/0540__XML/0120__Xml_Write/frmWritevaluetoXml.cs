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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/WritevaluetoXml.htm
    public partial  class frmWritevaluetoXml:Form
    {
        public frmWritevaluetoXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritevaluetoXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritevaluetoXml";
            this.Text = "frmWritevaluetoXml";
            this.Load += new System.EventHandler(this.frmWritevaluetoXml_Load);
            this.ResumeLayout(false);

        }

        private void frmWritevaluetoXml_Load(object sender, EventArgs e)
        {

        }
    }
}
