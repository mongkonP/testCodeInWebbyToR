using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0820__FindAll
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DataFilteringAndSorting.htm
    public partial  class frmDataFilteringAndSorting:Form
    {
        public frmDataFilteringAndSorting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataFilteringAndSorting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataFilteringAndSorting";
            this.Text = "frmDataFilteringAndSorting";
            this.Load += new System.EventHandler(this.frmDataFilteringAndSorting_Load);
            this.ResumeLayout(false);

        }

        private void frmDataFilteringAndSorting_Load(object sender, EventArgs e)
        {

        }
    }
}
