using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListSortWithComparisonDelegate.htm
    public partial  class frmListSortWithComparisonDelegate:Form
    {
        public frmListSortWithComparisonDelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListSortWithComparisonDelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListSortWithComparisonDelegate";
            this.Text = "frmListSortWithComparisonDelegate";
            this.Load += new System.EventHandler(this.frmListSortWithComparisonDelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmListSortWithComparisonDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
