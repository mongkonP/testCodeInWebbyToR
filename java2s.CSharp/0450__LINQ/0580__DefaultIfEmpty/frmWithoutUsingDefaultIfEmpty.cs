using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0580__DefaultIfEmpty
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/WithoutUsingDefaultIfEmpty.htm
    public partial  class frmWithoutUsingDefaultIfEmpty:Form
    {
        public frmWithoutUsingDefaultIfEmpty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWithoutUsingDefaultIfEmpty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWithoutUsingDefaultIfEmpty";
            this.Text = "frmWithoutUsingDefaultIfEmpty";
            this.Load += new System.EventHandler(this.frmWithoutUsingDefaultIfEmpty_Load);
            this.ResumeLayout(false);

        }

        private void frmWithoutUsingDefaultIfEmpty_Load(object sender, EventArgs e)
        {

        }
    }
}
