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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/BoxintsintoArrayList.htm
    public partial  class frmBoxintsintoArrayList:Form
    {
        public frmBoxintsintoArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBoxintsintoArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBoxintsintoArrayList";
            this.Text = "frmBoxintsintoArrayList";
            this.Load += new System.EventHandler(this.frmBoxintsintoArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmBoxintsintoArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
