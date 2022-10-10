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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NestedCount.htm
    public partial  class frmNestedCount:Form
    {
        public frmNestedCount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedCount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedCount";
            this.Text = "frmNestedCount";
            this.Load += new System.EventHandler(this.frmNestedCount_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedCount_Load(object sender, EventArgs e)
        {

        }
    }
}
