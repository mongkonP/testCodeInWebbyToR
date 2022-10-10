using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1200__Reverse
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AnExampleCallingtheReverseOperator.htm
    public partial  class frmAnExampleCallingtheReverseOperator:Form
    {
        public frmAnExampleCallingtheReverseOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnExampleCallingtheReverseOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnExampleCallingtheReverseOperator";
            this.Text = "frmAnExampleCallingtheReverseOperator";
            this.Load += new System.EventHandler(this.frmAnExampleCallingtheReverseOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmAnExampleCallingtheReverseOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
