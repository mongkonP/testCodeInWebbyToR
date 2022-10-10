using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangeHeight.htm
    public partial  class frmChangeHeight:Form
    {
        public frmChangeHeight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeHeight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeHeight";
            this.Text = "frmChangeHeight";
            this.Load += new System.EventHandler(this.frmChangeHeight_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeHeight_Load(object sender, EventArgs e)
        {

        }
    }
}
