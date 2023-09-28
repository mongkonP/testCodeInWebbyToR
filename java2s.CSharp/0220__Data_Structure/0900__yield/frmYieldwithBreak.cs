using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0900__yield
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/YieldwithBreak.htm
    public partial  class frmYieldwithBreak:Form
    {
        public frmYieldwithBreak()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmYieldwithBreak
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmYieldwithBreak";
            this.Text = "frmYieldwithBreak";
            this.Load += new System.EventHandler(this.frmYieldwithBreak_Load);
            this.ResumeLayout(false);

        }

        private void frmYieldwithBreak_Load(object sender, EventArgs e)
        {

        }
    }
}
