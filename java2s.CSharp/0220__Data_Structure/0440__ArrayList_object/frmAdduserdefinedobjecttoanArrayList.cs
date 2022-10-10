using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0440__ArrayList_object
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/AdduserdefinedobjecttoanArrayList.htm
    public partial  class frmAdduserdefinedobjecttoanArrayList:Form
    {
        public frmAdduserdefinedobjecttoanArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAdduserdefinedobjecttoanArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAdduserdefinedobjecttoanArrayList";
            this.Text = "frmAdduserdefinedobjecttoanArrayList";
            this.Load += new System.EventHandler(this.frmAdduserdefinedobjecttoanArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmAdduserdefinedobjecttoanArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
