using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0720__LinkList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Addthreeelementstotheendofthelist.htm
    public partial  class frmAddthreeelementstotheendofthelist:Form
    {
        public frmAddthreeelementstotheendofthelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddthreeelementstotheendofthelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddthreeelementstotheendofthelist";
            this.Text = "frmAddthreeelementstotheendofthelist";
            this.Load += new System.EventHandler(this.frmAddthreeelementstotheendofthelist_Load);
            this.ResumeLayout(false);

        }

        private void frmAddthreeelementstotheendofthelist_Load(object sender, EventArgs e)
        {

        }
    }
}
