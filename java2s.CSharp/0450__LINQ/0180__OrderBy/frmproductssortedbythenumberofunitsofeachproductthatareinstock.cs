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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/productssortedbythenumberofunitsofeachproductthatareinstock.htm
    public partial  class frmproductssortedbythenumberofunitsofeachproductthatareinstock:Form
    {
        public frmproductssortedbythenumberofunitsofeachproductthatareinstock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmproductssortedbythenumberofunitsofeachproductthatareinstock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmproductssortedbythenumberofunitsofeachproductthatareinstock";
            this.Text = "frmproductssortedbythenumberofunitsofeachproductthatareinstock";
            this.Load += new System.EventHandler(this.frmproductssortedbythenumberofunitsofeachproductthatareinstock_Load);
            this.ResumeLayout(false);

        }

        private void frmproductssortedbythenumberofunitsofeachproductthatareinstock_Load(object sender, EventArgs e)
        {

        }
    }
}
