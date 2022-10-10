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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetWindowHeightandWidth.htm
    public partial  class frmSetWindowHeightandWidth:Form
    {
        public frmSetWindowHeightandWidth()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetWindowHeightandWidth
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetWindowHeightandWidth";
            this.Text = "frmSetWindowHeightandWidth";
            this.Load += new System.EventHandler(this.frmSetWindowHeightandWidth_Load);
            this.ResumeLayout(false);

        }

        private void frmSetWindowHeightandWidth_Load(object sender, EventArgs e)
        {

        }
    }
}
