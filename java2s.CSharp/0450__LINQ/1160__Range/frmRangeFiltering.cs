using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1160__Range
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeFiltering.htm
    public partial  class frmRangeFiltering:Form
    {
        public frmRangeFiltering()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeFiltering
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeFiltering";
            this.Text = "frmRangeFiltering";
            this.Load += new System.EventHandler(this.frmRangeFiltering_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeFiltering_Load(object sender, EventArgs e)
        {

        }
    }
}
