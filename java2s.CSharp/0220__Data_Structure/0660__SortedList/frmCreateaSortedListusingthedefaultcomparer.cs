using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0660__SortedList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/CreateaSortedListusingthedefaultcomparer.htm
    public partial  class frmCreateaSortedListusingthedefaultcomparer:Form
    {
        public frmCreateaSortedListusingthedefaultcomparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaSortedListusingthedefaultcomparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaSortedListusingthedefaultcomparer";
            this.Text = "frmCreateaSortedListusingthedefaultcomparer";
            this.Load += new System.EventHandler(this.frmCreateaSortedListusingthedefaultcomparer_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaSortedListusingthedefaultcomparer_Load(object sender, EventArgs e)
        {

        }
    }
}
