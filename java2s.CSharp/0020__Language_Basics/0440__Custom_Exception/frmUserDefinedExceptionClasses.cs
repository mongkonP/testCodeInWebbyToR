using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0440__Custom_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/UserDefinedExceptionClasses.htm
    public partial  class frmUserDefinedExceptionClasses:Form
    {
        public frmUserDefinedExceptionClasses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserDefinedExceptionClasses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserDefinedExceptionClasses";
            this.Text = "frmUserDefinedExceptionClasses";
            this.Load += new System.EventHandler(this.frmUserDefinedExceptionClasses_Load);
            this.ResumeLayout(false);

        }

        private void frmUserDefinedExceptionClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
