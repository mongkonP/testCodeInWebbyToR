using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0500__Compound_from
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/PrintingthecustomernumberandorderIDforeveryorderinthelist.htm
    public partial  class frmPrintingthecustomernumberandorderIDforeveryorderinthelist:Form
    {
        public frmPrintingthecustomernumberandorderIDforeveryorderinthelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintingthecustomernumberandorderIDforeveryorderinthelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintingthecustomernumberandorderIDforeveryorderinthelist";
            this.Text = "frmPrintingthecustomernumberandorderIDforeveryorderinthelist";
            this.Load += new System.EventHandler(this.frmPrintingthecustomernumberandorderIDforeveryorderinthelist_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintingthecustomernumberandorderIDforeveryorderinthelist_Load(object sender, EventArgs e)
        {

        }
    }
}
