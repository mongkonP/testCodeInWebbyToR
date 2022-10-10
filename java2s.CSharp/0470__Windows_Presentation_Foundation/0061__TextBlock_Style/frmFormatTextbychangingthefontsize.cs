using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FormatTextbychangingthefontsize.htm
    public partial  class frmFormatTextbychangingthefontsize:Form
    {
        public frmFormatTextbychangingthefontsize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatTextbychangingthefontsize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatTextbychangingthefontsize";
            this.Text = "frmFormatTextbychangingthefontsize";
            this.Load += new System.EventHandler(this.frmFormatTextbychangingthefontsize_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatTextbychangingthefontsize_Load(object sender, EventArgs e)
        {

        }
    }
}
