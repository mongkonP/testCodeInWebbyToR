using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SingleBezier.htm
    public partial  class frmSingleBezier:Form
    {
        public frmSingleBezier()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSingleBezier
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSingleBezier";
            this.Text = "frmSingleBezier";
            this.Load += new System.EventHandler(this.frmSingleBezier_Load);
            this.ResumeLayout(false);

        }

        private void frmSingleBezier_Load(object sender, EventArgs e)
        {

        }
    }
}
