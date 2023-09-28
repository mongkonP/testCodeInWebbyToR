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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharIsWhiteSpace.htm
    public partial  class frmCharIsWhiteSpace:Form
    {
        public frmCharIsWhiteSpace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharIsWhiteSpace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharIsWhiteSpace";
            this.Text = "frmCharIsWhiteSpace";
            this.Load += new System.EventHandler(this.frmCharIsWhiteSpace_Load);
            this.ResumeLayout(false);

        }

        private void frmCharIsWhiteSpace_Load(object sender, EventArgs e)
        {

        }
    }
}
