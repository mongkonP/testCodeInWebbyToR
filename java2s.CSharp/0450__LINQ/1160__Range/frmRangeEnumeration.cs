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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/RangeEnumeration.htm
    public partial  class frmRangeEnumeration:Form
    {
        public frmRangeEnumeration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRangeEnumeration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRangeEnumeration";
            this.Text = "frmRangeEnumeration";
            this.Load += new System.EventHandler(this.frmRangeEnumeration_Load);
            this.ResumeLayout(false);

        }

        private void frmRangeEnumeration_Load(object sender, EventArgs e)
        {

        }
    }
}
