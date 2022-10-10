using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0120__Multi_Dimensional_Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/InitializingaTwoDimensionalArrayofIntegers.htm
    public partial  class frmInitializingaTwoDimensionalArrayofIntegers:Form
    {
        public frmInitializingaTwoDimensionalArrayofIntegers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInitializingaTwoDimensionalArrayofIntegers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInitializingaTwoDimensionalArrayofIntegers";
            this.Text = "frmInitializingaTwoDimensionalArrayofIntegers";
            this.Load += new System.EventHandler(this.frmInitializingaTwoDimensionalArrayofIntegers_Load);
            this.ResumeLayout(false);

        }

        private void frmInitializingaTwoDimensionalArrayofIntegers_Load(object sender, EventArgs e)
        {

        }
    }
}
