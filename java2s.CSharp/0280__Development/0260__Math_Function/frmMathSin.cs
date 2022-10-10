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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/MathSin.htm
    public partial  class frmMathSin:Form
    {
        public frmMathSin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMathSin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMathSin";
            this.Text = "frmMathSin";
            this.Load += new System.EventHandler(this.frmMathSin_Load);
            this.ResumeLayout(false);

        }

        private void frmMathSin_Load(object sender, EventArgs e)
        {

        }
    }
}
