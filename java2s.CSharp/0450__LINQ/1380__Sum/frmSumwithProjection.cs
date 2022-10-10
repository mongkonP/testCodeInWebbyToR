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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SumwithProjection.htm
    public partial  class frmSumwithProjection:Form
    {
        public frmSumwithProjection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSumwithProjection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSumwithProjection";
            this.Text = "frmSumwithProjection";
            this.Load += new System.EventHandler(this.frmSumwithProjection_Load);
            this.ResumeLayout(false);

        }

        private void frmSumwithProjection_Load(object sender, EventArgs e)
        {

        }
    }
}
