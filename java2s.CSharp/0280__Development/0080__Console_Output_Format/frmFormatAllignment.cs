using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0080__richTextBox1_Output_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/FormatAllignment.htm
    public partial  class frmFormatAllignment:Form
    {
        public frmFormatAllignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatAllignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatAllignment";
            this.Text = "frmFormatAllignment";
            this.Load += new System.EventHandler(this.frmFormatAllignment_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatAllignment_Load(object sender, EventArgs e)
        {

        }
    }
}
