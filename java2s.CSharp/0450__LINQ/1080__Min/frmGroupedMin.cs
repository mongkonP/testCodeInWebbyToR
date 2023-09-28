using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1080__Min
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupedMin.htm
    public partial  class frmGroupedMin:Form
    {
        public frmGroupedMin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupedMin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupedMin";
            this.Text = "frmGroupedMin";
            this.Load += new System.EventHandler(this.frmGroupedMin_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupedMin_Load(object sender, EventArgs e)
        {

        }
    }
}
