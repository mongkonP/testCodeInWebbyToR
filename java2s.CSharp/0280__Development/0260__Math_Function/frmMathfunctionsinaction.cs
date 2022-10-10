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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Mathfunctionsinaction.htm
    public partial  class frmMathfunctionsinaction:Form
    {
        public frmMathfunctionsinaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMathfunctionsinaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMathfunctionsinaction";
            this.Text = "frmMathfunctionsinaction";
            this.Load += new System.EventHandler(this.frmMathfunctionsinaction_Load);
            this.ResumeLayout(false);

        }

        private void frmMathfunctionsinaction_Load(object sender, EventArgs e)
        {

        }
    }
}
