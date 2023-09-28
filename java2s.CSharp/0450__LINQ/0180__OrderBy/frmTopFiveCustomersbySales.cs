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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/TopFiveCustomersbySales.htm
    public partial  class frmTopFiveCustomersbySales:Form
    {
        public frmTopFiveCustomersbySales()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTopFiveCustomersbySales
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTopFiveCustomersbySales";
            this.Text = "frmTopFiveCustomersbySales";
            this.Load += new System.EventHandler(this.frmTopFiveCustomersbySales_Load);
            this.ResumeLayout(false);

        }

        private void frmTopFiveCustomersbySales_Load(object sender, EventArgs e)
        {

        }
    }
}
