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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListFilteringWithLinq.htm
    public partial  class frmListFilteringWithLinq:Form
    {
        public frmListFilteringWithLinq()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListFilteringWithLinq
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListFilteringWithLinq";
            this.Text = "frmListFilteringWithLinq";
            this.Load += new System.EventHandler(this.frmListFilteringWithLinq_Load);
            this.ResumeLayout(false);

        }

        private void frmListFilteringWithLinq_Load(object sender, EventArgs e)
        {

        }
    }
}
