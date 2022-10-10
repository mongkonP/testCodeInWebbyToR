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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Useyieldbreak.htm
    public partial  class frmUseyieldbreak:Form
    {
        public frmUseyieldbreak()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseyieldbreak
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseyieldbreak";
            this.Text = "frmUseyieldbreak";
            this.Load += new System.EventHandler(this.frmUseyieldbreak_Load);
            this.ResumeLayout(false);

        }

        private void frmUseyieldbreak_Load(object sender, EventArgs e)
        {

        }
    }
}
