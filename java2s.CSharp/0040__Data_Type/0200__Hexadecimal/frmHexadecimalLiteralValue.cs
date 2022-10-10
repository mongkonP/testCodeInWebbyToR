using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0200__Hexadecimal
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/HexadecimalLiteralValue.htm
    public partial  class frmHexadecimalLiteralValue:Form
    {
        public frmHexadecimalLiteralValue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHexadecimalLiteralValue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHexadecimalLiteralValue";
            this.Text = "frmHexadecimalLiteralValue";
            this.Load += new System.EventHandler(this.frmHexadecimalLiteralValue_Load);
            this.ResumeLayout(false);

        }

        private void frmHexadecimalLiteralValue_Load(object sender, EventArgs e)
        {

        }
    }
}
