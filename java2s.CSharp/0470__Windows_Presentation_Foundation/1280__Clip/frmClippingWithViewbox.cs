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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ClippingWithViewbox.htm
    public partial  class frmClippingWithViewbox:Form
    {
        public frmClippingWithViewbox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClippingWithViewbox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClippingWithViewbox";
            this.Text = "frmClippingWithViewbox";
            this.Load += new System.EventHandler(this.frmClippingWithViewbox_Load);
            this.ResumeLayout(false);

        }

        private void frmClippingWithViewbox_Load(object sender, EventArgs e)
        {

        }
    }
}
