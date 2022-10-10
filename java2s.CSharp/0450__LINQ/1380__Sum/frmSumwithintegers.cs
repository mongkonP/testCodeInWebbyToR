using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1380__Sum
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Sumwithintegers.htm
    public partial  class frmSumwithintegers:Form
    {
        public frmSumwithintegers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSumwithintegers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSumwithintegers";
            this.Text = "frmSumwithintegers";
            this.Load += new System.EventHandler(this.frmSumwithintegers_Load);
            this.ResumeLayout(false);

        }

        private void frmSumwithintegers_Load(object sender, EventArgs e)
        {

        }
    }
}
