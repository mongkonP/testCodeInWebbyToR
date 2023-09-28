using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListSortWithComparer.htm
    public partial  class frmListSortWithComparer:Form
    {
        public frmListSortWithComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListSortWithComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListSortWithComparer";
            this.Text = "frmListSortWithComparer";
            this.Load += new System.EventHandler(this.frmListSortWithComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmListSortWithComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
