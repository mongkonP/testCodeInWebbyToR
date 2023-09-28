using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0100__Array_Bound
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Getlowerboundandupperbound.htm
    public partial  class frmGetlowerboundandupperbound:Form
    {
        public frmGetlowerboundandupperbound()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetlowerboundandupperbound
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetlowerboundandupperbound";
            this.Text = "frmGetlowerboundandupperbound";
            this.Load += new System.EventHandler(this.frmGetlowerboundandupperbound_Load);
            this.ResumeLayout(false);

        }

        private void frmGetlowerboundandupperbound_Load(object sender, EventArgs e)
        {

        }
    }
}
