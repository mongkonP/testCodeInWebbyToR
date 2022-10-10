using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1300__Single
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UsingSingle.htm
    public partial  class frmUsingSingle:Form
    {
        public frmUsingSingle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingSingle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingSingle";
            this.Text = "frmUsingSingle";
            this.Load += new System.EventHandler(this.frmUsingSingle_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingSingle_Load(object sender, EventArgs e)
        {

        }
    }
}
