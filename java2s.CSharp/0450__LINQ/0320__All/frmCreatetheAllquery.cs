using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0320__All
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CreatetheAllquery.htm
    public partial  class frmCreatetheAllquery:Form
    {
        public frmCreatetheAllquery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatetheAllquery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatetheAllquery";
            this.Text = "frmCreatetheAllquery";
            this.Load += new System.EventHandler(this.frmCreatetheAllquery_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatetheAllquery_Load(object sender, EventArgs e)
        {

        }
    }
}
