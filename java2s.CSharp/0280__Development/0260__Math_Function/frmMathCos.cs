using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0260__Math_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/MathCos.htm
    public partial  class frmMathCos:Form
    {
        public frmMathCos()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMathCos
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMathCos";
            this.Text = "frmMathCos";
            this.Load += new System.EventHandler(this.frmMathCos_Load);
            this.ResumeLayout(false);

        }

        private void frmMathCos_Load(object sender, EventArgs e)
        {

        }
    }
}
