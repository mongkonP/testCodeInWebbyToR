using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0180__operator_overload_Binary_Plus_Subtract
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/Operatoroverloading.htm
    public partial  class frmOperatoroverloading:Form
    {
        public frmOperatoroverloading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOperatoroverloading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOperatoroverloading";
            this.Text = "frmOperatoroverloading";
            this.Load += new System.EventHandler(this.frmOperatoroverloading_Load);
            this.ResumeLayout(false);

        }

        private void frmOperatoroverloading_Load(object sender, EventArgs e)
        {

        }
    }
}
