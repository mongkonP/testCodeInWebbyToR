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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeProjection.htm
    public partial  class frmRangeProjection:Form
    {
        public frmRangeProjection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeProjection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeProjection";
            this.Text = "frmRangeProjection";
            this.Load += new System.EventHandler(this.frmRangeProjection_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeProjection_Load(object sender, EventArgs e)
        {

        }
    }
}
