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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DisplayProductsWithUnknownPrice.htm
    public partial  class frmDisplayProductsWithUnknownPrice:Form
    {
        public frmDisplayProductsWithUnknownPrice()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayProductsWithUnknownPrice
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayProductsWithUnknownPrice";
            this.Text = "frmDisplayProductsWithUnknownPrice";
            this.Load += new System.EventHandler(this.frmDisplayProductsWithUnknownPrice_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayProductsWithUnknownPrice_Load(object sender, EventArgs e)
        {

        }
    }
}
