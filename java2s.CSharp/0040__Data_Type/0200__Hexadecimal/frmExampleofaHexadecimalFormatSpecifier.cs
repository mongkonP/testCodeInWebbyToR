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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ExampleofaHexadecimalFormatSpecifier.htm
    public partial  class frmExampleofaHexadecimalFormatSpecifier:Form
    {
        public frmExampleofaHexadecimalFormatSpecifier()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExampleofaHexadecimalFormatSpecifier
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExampleofaHexadecimalFormatSpecifier";
            this.Text = "frmExampleofaHexadecimalFormatSpecifier";
            this.Load += new System.EventHandler(this.frmExampleofaHexadecimalFormatSpecifier_Load);
            this.ResumeLayout(false);

        }

        private void frmExampleofaHexadecimalFormatSpecifier_Load(object sender, EventArgs e)
        {

        }
    }
}
