using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0360__Average
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupedAverage.htm
    public partial  class frmGroupedAverage:Form
    {
        public frmGroupedAverage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupedAverage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupedAverage";
            this.Text = "frmGroupedAverage";
            this.Load += new System.EventHandler(this.frmGroupedAverage_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupedAverage_Load(object sender, EventArgs e)
        {

        }
    }
}
