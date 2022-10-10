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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DeclaringaTwoDimensionalArray.htm
    public partial  class frmDeclaringaTwoDimensionalArray:Form
    {
        public frmDeclaringaTwoDimensionalArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclaringaTwoDimensionalArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclaringaTwoDimensionalArray";
            this.Text = "frmDeclaringaTwoDimensionalArray";
            this.Load += new System.EventHandler(this.frmDeclaringaTwoDimensionalArray_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclaringaTwoDimensionalArray_Load(object sender, EventArgs e)
        {

        }
    }
}
