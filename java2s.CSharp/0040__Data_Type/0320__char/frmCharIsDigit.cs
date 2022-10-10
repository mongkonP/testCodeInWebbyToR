using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0320__char
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharIsDigit.htm
    public partial  class frmCharIsDigit:Form
    {
        public frmCharIsDigit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharIsDigit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharIsDigit";
            this.Text = "frmCharIsDigit";
            this.Load += new System.EventHandler(this.frmCharIsDigit_Load);
            this.ResumeLayout(false);

        }

        private void frmCharIsDigit_Load(object sender, EventArgs e)
        {

        }
    }
}
