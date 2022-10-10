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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NotinTopFiveCustomersbySales.htm
    public partial  class frmNotinTopFiveCustomersbySales:Form
    {
        public frmNotinTopFiveCustomersbySales()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNotinTopFiveCustomersbySales
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNotinTopFiveCustomersbySales";
            this.Text = "frmNotinTopFiveCustomersbySales";
            this.Load += new System.EventHandler(this.frmNotinTopFiveCustomersbySales_Load);
            this.ResumeLayout(false);

        }

        private void frmNotinTopFiveCustomersbySales_Load(object sender, EventArgs e)
        {

        }
    }
}
