using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SizeToContentWidthAndHeight.htm
    public partial  class frmSizeToContentWidthAndHeight:Form
    {
        public frmSizeToContentWidthAndHeight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSizeToContentWidthAndHeight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSizeToContentWidthAndHeight";
            this.Text = "frmSizeToContentWidthAndHeight";
            this.Load += new System.EventHandler(this.frmSizeToContentWidthAndHeight_Load);
            this.ResumeLayout(false);

        }

        private void frmSizeToContentWidthAndHeight_Load(object sender, EventArgs e)
        {

        }
    }
}
