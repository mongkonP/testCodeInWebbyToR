using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0520__BinaryReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Resetthefilepointertothestart.htm
    public partial  class frmResetthefilepointertothestart:Form
    {
        public frmResetthefilepointertothestart()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResetthefilepointertothestart
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResetthefilepointertothestart";
            this.Text = "frmResetthefilepointertothestart";
            this.Load += new System.EventHandler(this.frmResetthefilepointertothestart_Load);
            this.ResumeLayout(false);

        }

        private void frmResetthefilepointertothestart_Load(object sender, EventArgs e)
        {

        }
    }
}
