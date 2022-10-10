using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0160__RandomNumberGenerator
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Generate32bytesofrandomdata.htm
    public partial  class frmGenerate32bytesofrandomdata:Form
    {
        public frmGenerate32bytesofrandomdata()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenerate32bytesofrandomdata
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenerate32bytesofrandomdata";
            this.Text = "frmGenerate32bytesofrandomdata";
            this.Load += new System.EventHandler(this.frmGenerate32bytesofrandomdata_Load);
            this.ResumeLayout(false);

        }

        private void frmGenerate32bytesofrandomdata_Load(object sender, EventArgs e)
        {

        }
    }
}
