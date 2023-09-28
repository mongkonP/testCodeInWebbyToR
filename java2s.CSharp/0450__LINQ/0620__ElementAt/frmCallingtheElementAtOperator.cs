using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0620__ElementAt
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CallingtheElementAtOperator.htm
    public partial  class frmCallingtheElementAtOperator:Form
    {
        public frmCallingtheElementAtOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallingtheElementAtOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallingtheElementAtOperator";
            this.Text = "frmCallingtheElementAtOperator";
            this.Load += new System.EventHandler(this.frmCallingtheElementAtOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmCallingtheElementAtOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
