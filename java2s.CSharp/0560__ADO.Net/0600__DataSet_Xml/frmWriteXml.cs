using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0600__DataSet_Xml
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/WriteXml.htm
    public partial  class frmWriteXml:Form
    {
        public frmWriteXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriteXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriteXml";
            this.Text = "frmWriteXml";
            this.Load += new System.EventHandler(this.frmWriteXml_Load);
            this.ResumeLayout(false);

        }

        private void frmWriteXml_Load(object sender, EventArgs e)
        {

        }
    }
}
