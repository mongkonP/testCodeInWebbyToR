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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/IcecreamswithLeastPrice.htm
    public partial  class frmIcecreamswithLeastPrice:Form
    {
        public frmIcecreamswithLeastPrice()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIcecreamswithLeastPrice
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIcecreamswithLeastPrice";
            this.Text = "frmIcecreamswithLeastPrice";
            this.Load += new System.EventHandler(this.frmIcecreamswithLeastPrice_Load);
            this.ResumeLayout(false);

        }

        private void frmIcecreamswithLeastPrice_Load(object sender, EventArgs e)
        {

        }
    }
}
