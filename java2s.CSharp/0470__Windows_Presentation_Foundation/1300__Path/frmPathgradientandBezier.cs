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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PathgradientandBezier.htm
    public partial  class frmPathgradientandBezier:Form
    {
        public frmPathgradientandBezier()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPathgradientandBezier
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPathgradientandBezier";
            this.Text = "frmPathgradientandBezier";
            this.Load += new System.EventHandler(this.frmPathgradientandBezier_Load);
            this.ResumeLayout(false);

        }

        private void frmPathgradientandBezier_Load(object sender, EventArgs e)
        {

        }
    }
}
