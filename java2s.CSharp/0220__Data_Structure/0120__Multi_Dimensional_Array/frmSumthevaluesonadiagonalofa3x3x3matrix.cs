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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Sumthevaluesonadiagonalofa3x3x3matrix.htm
    public partial  class frmSumthevaluesonadiagonalofa3x3x3matrix:Form
    {
        public frmSumthevaluesonadiagonalofa3x3x3matrix()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSumthevaluesonadiagonalofa3x3x3matrix
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSumthevaluesonadiagonalofa3x3x3matrix";
            this.Text = "frmSumthevaluesonadiagonalofa3x3x3matrix";
            this.Load += new System.EventHandler(this.frmSumthevaluesonadiagonalofa3x3x3matrix_Load);
            this.ResumeLayout(false);

        }

        private void frmSumthevaluesonadiagonalofa3x3x3matrix_Load(object sender, EventArgs e)
        {

        }
    }
}
