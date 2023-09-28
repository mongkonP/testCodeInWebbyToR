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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Demonstratesthe3constructorsofArrayList.htm
    public partial  class frmDemonstratesthe3constructorsofArrayList:Form
    {
        public frmDemonstratesthe3constructorsofArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratesthe3constructorsofArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratesthe3constructorsofArrayList";
            this.Text = "frmDemonstratesthe3constructorsofArrayList";
            this.Load += new System.EventHandler(this.frmDemonstratesthe3constructorsofArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratesthe3constructorsofArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
