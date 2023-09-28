using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1400__Take
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NestedTake.htm
    public partial  class frmNestedTake:Form
    {
        public frmNestedTake()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedTake
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedTake";
            this.Text = "frmNestedTake";
            this.Load += new System.EventHandler(this.frmNestedTake_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedTake_Load(object sender, EventArgs e)
        {

        }
    }
}
