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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/MathTan.htm
    public partial  class frmMathTan:Form
    {
        public frmMathTan()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMathTan
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMathTan";
            this.Text = "frmMathTan";
            this.Load += new System.EventHandler(this.frmMathTan_Load);
            this.ResumeLayout(false);

        }

        private void frmMathTan_Load(object sender, EventArgs e)
        {

        }
    }
}
