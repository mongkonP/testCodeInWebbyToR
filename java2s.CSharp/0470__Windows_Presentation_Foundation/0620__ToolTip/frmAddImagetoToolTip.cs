using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0620__ToolTip
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddImagetoToolTip.htm
    public partial  class frmAddImagetoToolTip:Form
    {
        public frmAddImagetoToolTip()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddImagetoToolTip
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddImagetoToolTip";
            this.Text = "frmAddImagetoToolTip";
            this.Load += new System.EventHandler(this.frmAddImagetoToolTip_Load);
            this.ResumeLayout(false);

        }

        private void frmAddImagetoToolTip_Load(object sender, EventArgs e)
        {

        }
    }
}
