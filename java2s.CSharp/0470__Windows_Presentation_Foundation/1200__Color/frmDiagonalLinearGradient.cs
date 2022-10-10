using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1200__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DiagonalLinearGradient.htm
    public partial  class frmDiagonalLinearGradient:Form
    {
        public frmDiagonalLinearGradient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDiagonalLinearGradient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDiagonalLinearGradient";
            this.Text = "frmDiagonalLinearGradient";
            this.Load += new System.EventHandler(this.frmDiagonalLinearGradient_Load);
            this.ResumeLayout(false);

        }

        private void frmDiagonalLinearGradient_Load(object sender, EventArgs e)
        {

        }
    }
}
