using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1280__Clip
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DynamicClipping.htm
    public partial  class frmDynamicClipping:Form
    {
        public frmDynamicClipping()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicClipping
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicClipping";
            this.Text = "frmDynamicClipping";
            this.Load += new System.EventHandler(this.frmDynamicClipping_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicClipping_Load(object sender, EventArgs e)
        {

        }
    }
}
