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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderBywithpassingalambdafunction.htm
    public partial  class frmOrderBywithpassingalambdafunction:Form
    {
        public frmOrderBywithpassingalambdafunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderBywithpassingalambdafunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderBywithpassingalambdafunction";
            this.Text = "frmOrderBywithpassingalambdafunction";
            this.Load += new System.EventHandler(this.frmOrderBywithpassingalambdafunction_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderBywithpassingalambdafunction_Load(object sender, EventArgs e)
        {

        }
    }
}
