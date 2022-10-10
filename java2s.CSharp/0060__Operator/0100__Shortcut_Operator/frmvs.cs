using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0100__Shortcut_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/vs.htm
    public partial  class frmvs:Form
    {
        public frmvs()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmvs
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmvs";
            this.Text = "frmvs";
            this.Load += new System.EventHandler(this.frmvs_Load);
            this.ResumeLayout(false);

        }

        private void frmvs_Load(object sender, EventArgs e)
        {

        }
    }
}
