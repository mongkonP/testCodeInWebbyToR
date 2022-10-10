using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0460__ArrayList_Display
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UseforeachlooptodisplaytheArrayList.htm
    public partial  class frmUseforeachlooptodisplaytheArrayList:Form
    {
        public frmUseforeachlooptodisplaytheArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseforeachlooptodisplaytheArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseforeachlooptodisplaytheArrayList";
            this.Text = "frmUseforeachlooptodisplaytheArrayList";
            this.Load += new System.EventHandler(this.frmUseforeachlooptodisplaytheArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmUseforeachlooptodisplaytheArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
