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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Useinwhereclause.htm
    public partial  class frmUseinwhereclause:Form
    {
        public frmUseinwhereclause()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseinwhereclause
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseinwhereclause";
            this.Text = "frmUseinwhereclause";
            this.Load += new System.EventHandler(this.frmUseinwhereclause_Load);
            this.ResumeLayout(false);

        }

        private void frmUseinwhereclause_Load(object sender, EventArgs e)
        {

        }
    }
}
