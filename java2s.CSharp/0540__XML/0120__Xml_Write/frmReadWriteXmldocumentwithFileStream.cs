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
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/ReadWriteXmldocumentwithFileStream.htm
    public partial  class frmReadWriteXmldocumentwithFileStream:Form
    {
        public frmReadWriteXmldocumentwithFileStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadWriteXmldocumentwithFileStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadWriteXmldocumentwithFileStream";
            this.Text = "frmReadWriteXmldocumentwithFileStream";
            this.Load += new System.EventHandler(this.frmReadWriteXmldocumentwithFileStream_Load);
            this.ResumeLayout(false);

        }

        private void frmReadWriteXmldocumentwithFileStream_Load(object sender, EventArgs e)
        {

        }
    }
}
