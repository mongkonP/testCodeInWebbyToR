using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ReturningaList.htm
    public partial  class frmReturningaList:Form
    {
        public frmReturningaList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturningaList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturningaList";
            this.Text = "frmReturningaList";
            this.Load += new System.EventHandler(this.frmReturningaList_Load);
            this.ResumeLayout(false);

        }

        private void frmReturningaList_Load(object sender, EventArgs e)
        {

        }
    }
}
