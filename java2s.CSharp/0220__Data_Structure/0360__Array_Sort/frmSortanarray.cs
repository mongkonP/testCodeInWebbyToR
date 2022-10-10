using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0360__Array_Sort
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Sortanarray.htm
    public partial  class frmSortanarray:Form
    {
        public frmSortanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSortanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSortanarray";
            this.Text = "frmSortanarray";
            this.Load += new System.EventHandler(this.frmSortanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmSortanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
