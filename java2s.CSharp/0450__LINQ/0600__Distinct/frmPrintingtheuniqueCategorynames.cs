using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0600__Distinct
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/PrintingtheuniqueCategorynames.htm
    public partial  class frmPrintingtheuniqueCategorynames:Form
    {
        public frmPrintingtheuniqueCategorynames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintingtheuniqueCategorynames
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintingtheuniqueCategorynames";
            this.Text = "frmPrintingtheuniqueCategorynames";
            this.Load += new System.EventHandler(this.frmPrintingtheuniqueCategorynames_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintingtheuniqueCategorynames_Load(object sender, EventArgs e)
        {

        }
    }
}
