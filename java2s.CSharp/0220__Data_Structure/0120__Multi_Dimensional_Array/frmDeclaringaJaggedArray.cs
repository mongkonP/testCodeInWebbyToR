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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DeclaringaJaggedArray.htm
    public partial  class frmDeclaringaJaggedArray:Form
    {
        public frmDeclaringaJaggedArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclaringaJaggedArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclaringaJaggedArray";
            this.Text = "frmDeclaringaJaggedArray";
            this.Load += new System.EventHandler(this.frmDeclaringaJaggedArray_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclaringaJaggedArray_Load(object sender, EventArgs e)
        {

        }
    }
}
