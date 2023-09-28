using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EmbeddedcodeforApplication.htm
    public partial  class frmEmbeddedcodeforApplication:Form
    {
        public frmEmbeddedcodeforApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmbeddedcodeforApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmbeddedcodeforApplication";
            this.Text = "frmEmbeddedcodeforApplication";
            this.Load += new System.EventHandler(this.frmEmbeddedcodeforApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmEmbeddedcodeforApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
