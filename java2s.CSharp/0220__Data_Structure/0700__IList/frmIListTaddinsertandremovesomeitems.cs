using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0700__IList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IListTaddinsertandremovesomeitems.htm
    public partial  class frmIListTaddinsertandremovesomeitems:Form
    {
        public frmIListTaddinsertandremovesomeitems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIListTaddinsertandremovesomeitems
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIListTaddinsertandremovesomeitems";
            this.Text = "frmIListTaddinsertandremovesomeitems";
            this.Load += new System.EventHandler(this.frmIListTaddinsertandremovesomeitems_Load);
            this.ResumeLayout(false);

        }

        private void frmIListTaddinsertandremovesomeitems_Load(object sender, EventArgs e)
        {

        }
    }
}
