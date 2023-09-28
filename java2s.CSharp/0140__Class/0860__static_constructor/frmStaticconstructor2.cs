using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0860__static_constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Staticconstructor2.htm
    public partial  class frmStaticconstructor2:Form
    {
        public frmStaticconstructor2()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticconstructor2
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticconstructor2";
            this.Text = "frmStaticconstructor2";
            this.Load += new System.EventHandler(this.frmStaticconstructor2_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticconstructor2_Load(object sender, EventArgs e)
        {

        }
    }
}
