using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/LoadtheSystemXmlassemblyusinganAssemblyName.htm
    public partial  class frmLoadtheSystemXmlassemblyusinganAssemblyName:Form
    {
        public frmLoadtheSystemXmlassemblyusinganAssemblyName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadtheSystemXmlassemblyusinganAssemblyName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadtheSystemXmlassemblyusinganAssemblyName";
            this.Text = "frmLoadtheSystemXmlassemblyusinganAssemblyName";
            this.Load += new System.EventHandler(this.frmLoadtheSystemXmlassemblyusinganAssemblyName_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadtheSystemXmlassemblyusinganAssemblyName_Load(object sender, EventArgs e)
        {

        }
    }
}
