using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2120__Resource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadResourceforApplication.htm
    public partial  class frmLoadResourceforApplication:Form
    {
        public frmLoadResourceforApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadResourceforApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadResourceforApplication";
            this.Text = "frmLoadResourceforApplication";
            this.Load += new System.EventHandler(this.frmLoadResourceforApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadResourceforApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
