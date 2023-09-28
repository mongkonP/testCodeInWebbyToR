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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/FormatCurrency.htm
    public partial  class frmFormatCurrency:Form
    {
        public frmFormatCurrency()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatCurrency
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatCurrency";
            this.Text = "frmFormatCurrency";
            this.Load += new System.EventHandler(this.frmFormatCurrency_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatCurrency_Load(object sender, EventArgs e)
        {

        }
    }
}
