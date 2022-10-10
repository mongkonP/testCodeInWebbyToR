using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0320__char
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ChartypeFunctionality.htm
    public partial  class frmChartypeFunctionality:Form
    {
        public frmChartypeFunctionality()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChartypeFunctionality
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChartypeFunctionality";
            this.Text = "frmChartypeFunctionality";
            this.Load += new System.EventHandler(this.frmChartypeFunctionality_Load);
            this.ResumeLayout(false);

        }

        private void frmChartypeFunctionality_Load(object sender, EventArgs e)
        {

        }
    }
}
