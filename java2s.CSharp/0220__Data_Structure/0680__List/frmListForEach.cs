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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListForEach.htm
    public partial  class frmListForEach:Form
    {
        public frmListForEach()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListForEach
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListForEach";
            this.Text = "frmListForEach";
            this.Load += new System.EventHandler(this.frmListForEach_Load);
            this.ResumeLayout(false);

        }

        private void frmListForEach_Load(object sender, EventArgs e)
        {

        }
    }
}
