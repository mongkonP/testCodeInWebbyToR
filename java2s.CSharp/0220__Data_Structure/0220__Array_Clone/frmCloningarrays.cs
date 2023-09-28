using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0220__Array_Clone
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Cloningarrays.htm
    public partial  class frmCloningarrays:Form
    {
        public frmCloningarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCloningarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCloningarrays";
            this.Text = "frmCloningarrays";
            this.Load += new System.EventHandler(this.frmCloningarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmCloningarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
