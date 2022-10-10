using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0060__richTextBox1_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Writewithoutnewline.htm
    public partial  class frmWritewithoutnewline:Form
    {
        public frmWritewithoutnewline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritewithoutnewline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritewithoutnewline";
            this.Text = "frmWritewithoutnewline";
            this.Load += new System.EventHandler(this.frmWritewithoutnewline_Load);
            this.ResumeLayout(false);

        }

        private void frmWritewithoutnewline_Load(object sender, EventArgs e)
        {

        }
    }
}
