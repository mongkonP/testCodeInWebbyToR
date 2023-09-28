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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ClearanArrayList.htm
    public partial  class frmClearanArrayList:Form
    {
        public frmClearanArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClearanArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClearanArrayList";
            this.Text = "frmClearanArrayList";
            this.Load += new System.EventHandler(this.frmClearanArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmClearanArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
