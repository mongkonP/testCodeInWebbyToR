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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UsetheReversemethodtoreversemyArrayList.htm
    public partial  class frmUsetheReversemethodtoreversemyArrayList:Form
    {
        public frmUsetheReversemethodtoreversemyArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheReversemethodtoreversemyArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheReversemethodtoreversemyArrayList";
            this.Text = "frmUsetheReversemethodtoreversemyArrayList";
            this.Load += new System.EventHandler(this.frmUsetheReversemethodtoreversemyArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheReversemethodtoreversemyArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
