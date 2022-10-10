using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0120__int_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Comparingintegers.htm
    public partial  class frmComparingintegers:Form
    {
        public frmComparingintegers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComparingintegers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComparingintegers";
            this.Text = "frmComparingintegers";
            this.Load += new System.EventHandler(this.frmComparingintegers_Load);
            this.ResumeLayout(false);

        }

        private void frmComparingintegers_Load(object sender, EventArgs e)
        {

        }
    }
}
