using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0360__Finally
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/DisposeaStreamWriterinfinallyblock.htm
    public partial  class frmDisposeaStreamWriterinfinallyblock:Form
    {
        public frmDisposeaStreamWriterinfinallyblock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisposeaStreamWriterinfinallyblock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisposeaStreamWriterinfinallyblock";
            this.Text = "frmDisposeaStreamWriterinfinallyblock";
            this.Load += new System.EventHandler(this.frmDisposeaStreamWriterinfinallyblock_Load);
            this.ResumeLayout(false);

        }

        private void frmDisposeaStreamWriterinfinallyblock_Load(object sender, EventArgs e)
        {

        }
    }
}
