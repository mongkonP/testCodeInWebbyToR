using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0400__StreamReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DemonstrateStringReaderandStringWriter.htm
    public partial  class frmDemonstrateStringReaderandStringWriter:Form
    {
        public frmDemonstrateStringReaderandStringWriter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateStringReaderandStringWriter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateStringReaderandStringWriter";
            this.Text = "frmDemonstrateStringReaderandStringWriter";
            this.Load += new System.EventHandler(this.frmDemonstrateStringReaderandStringWriter_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateStringReaderandStringWriter_Load(object sender, EventArgs e)
        {

        }
    }
}
