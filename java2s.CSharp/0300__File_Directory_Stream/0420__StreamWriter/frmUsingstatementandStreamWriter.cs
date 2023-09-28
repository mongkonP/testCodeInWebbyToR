using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0420__StreamWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UsingstatementandStreamWriter.htm
    public partial  class frmUsingstatementandStreamWriter:Form
    {
        public frmUsingstatementandStreamWriter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingstatementandStreamWriter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingstatementandStreamWriter";
            this.Text = "frmUsingstatementandStreamWriter";
            this.Load += new System.EventHandler(this.frmUsingstatementandStreamWriter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingstatementandStreamWriter_Load(object sender, EventArgs e)
        {

        }
    }
}
