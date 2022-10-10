using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0560__Count
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CountelementsinaRange.htm
    public partial  class frmCountelementsinaRange:Form
    {
        public frmCountelementsinaRange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCountelementsinaRange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCountelementsinaRange";
            this.Text = "frmCountelementsinaRange";
            this.Load += new System.EventHandler(this.frmCountelementsinaRange_Load);
            this.ResumeLayout(false);

        }

        private void frmCountelementsinaRange_Load(object sender, EventArgs e)
        {

        }
    }
}
