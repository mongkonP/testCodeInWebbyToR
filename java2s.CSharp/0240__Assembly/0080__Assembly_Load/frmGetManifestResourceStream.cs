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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/GetManifestResourceStream.htm
    public partial  class frmGetManifestResourceStream:Form
    {
        public frmGetManifestResourceStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetManifestResourceStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetManifestResourceStream";
            this.Text = "frmGetManifestResourceStream";
            this.Load += new System.EventHandler(this.frmGetManifestResourceStream_Load);
            this.ResumeLayout(false);

        }

        private void frmGetManifestResourceStream_Load(object sender, EventArgs e)
        {

        }
    }
}
