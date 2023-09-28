using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/SortandsearchanArrayList.htm
    public partial  class frmSortandsearchanArrayList:Form
    {
        public frmSortandsearchanArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSortandsearchanArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSortandsearchanArrayList";
            this.Text = "frmSortandsearchanArrayList";
            this.Load += new System.EventHandler(this.frmSortandsearchanArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmSortandsearchanArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
