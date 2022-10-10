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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderBywithcustomizedComparer.htm
    public partial  class frmOrderBywithcustomizedComparer:Form
    {
        public frmOrderBywithcustomizedComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderBywithcustomizedComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderBywithcustomizedComparer";
            this.Text = "frmOrderBywithcustomizedComparer";
            this.Load += new System.EventHandler(this.frmOrderBywithcustomizedComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderBywithcustomizedComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
