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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharIsLetter.htm
    public partial  class frmCharIsLetter:Form
    {
        public frmCharIsLetter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharIsLetter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharIsLetter";
            this.Text = "frmCharIsLetter";
            this.Load += new System.EventHandler(this.frmCharIsLetter_Load);
            this.ResumeLayout(false);

        }

        private void frmCharIsLetter_Load(object sender, EventArgs e)
        {

        }
    }
}
