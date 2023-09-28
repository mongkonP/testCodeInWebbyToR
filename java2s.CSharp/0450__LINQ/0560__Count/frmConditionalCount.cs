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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ConditionalCount.htm
    public partial  class frmConditionalCount:Form
    {
        public frmConditionalCount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConditionalCount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConditionalCount";
            this.Text = "frmConditionalCount";
            this.Load += new System.EventHandler(this.frmConditionalCount_Load);
            this.ResumeLayout(false);

        }

        private void frmConditionalCount_Load(object sender, EventArgs e)
        {

        }
    }
}
