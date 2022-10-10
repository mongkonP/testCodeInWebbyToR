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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/RemoveelementsfromArrayList.htm
    public partial  class frmRemoveelementsfromArrayList:Form
    {
        public frmRemoveelementsfromArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveelementsfromArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveelementsfromArrayList";
            this.Text = "frmRemoveelementsfromArrayList";
            this.Load += new System.EventHandler(this.frmRemoveelementsfromArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveelementsfromArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
