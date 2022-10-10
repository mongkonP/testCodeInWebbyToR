using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ModifyingWhereBehavior.htm
    public partial  class frmModifyingWhereBehavior:Form
    {
        public frmModifyingWhereBehavior()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyingWhereBehavior
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyingWhereBehavior";
            this.Text = "frmModifyingWhereBehavior";
            this.Load += new System.EventHandler(this.frmModifyingWhereBehavior_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyingWhereBehavior_Load(object sender, EventArgs e)
        {

        }
    }
}
