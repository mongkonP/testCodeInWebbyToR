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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Useenumeratortoaccesslist.htm
    public partial  class frmUseenumeratortoaccesslist:Form
    {
        public frmUseenumeratortoaccesslist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseenumeratortoaccesslist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseenumeratortoaccesslist";
            this.Text = "frmUseenumeratortoaccesslist";
            this.Load += new System.EventHandler(this.frmUseenumeratortoaccesslist_Load);
            this.ResumeLayout(false);

        }

        private void frmUseenumeratortoaccesslist_Load(object sender, EventArgs e)
        {

        }
    }
}
