using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderByDescending.htm
    public partial  class frmOrderByDescending:Form
    {
        public frmOrderByDescending()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderByDescending
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderByDescending";
            this.Text = "frmOrderByDescending";
            this.Load += new System.EventHandler(this.frmOrderByDescending_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderByDescending_Load(object sender, EventArgs e)
        {

        }
    }
}
