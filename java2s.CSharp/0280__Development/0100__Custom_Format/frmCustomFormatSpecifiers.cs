using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CustomFormatSpecifiers.htm
    public partial  class frmCustomFormatSpecifiers:Form
    {
        public frmCustomFormatSpecifiers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomFormatSpecifiers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomFormatSpecifiers";
            this.Text = "frmCustomFormatSpecifiers";
            this.Load += new System.EventHandler(this.frmCustomFormatSpecifiers_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomFormatSpecifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
