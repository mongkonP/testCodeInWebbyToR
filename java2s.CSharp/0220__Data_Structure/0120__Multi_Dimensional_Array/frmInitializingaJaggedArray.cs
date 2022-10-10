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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/InitializingaJaggedArray.htm
    public partial  class frmInitializingaJaggedArray:Form
    {
        public frmInitializingaJaggedArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInitializingaJaggedArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInitializingaJaggedArray";
            this.Text = "frmInitializingaJaggedArray";
            this.Load += new System.EventHandler(this.frmInitializingaJaggedArray_Load);
            this.ResumeLayout(false);

        }

        private void frmInitializingaJaggedArray_Load(object sender, EventArgs e)
        {

        }
    }
}
