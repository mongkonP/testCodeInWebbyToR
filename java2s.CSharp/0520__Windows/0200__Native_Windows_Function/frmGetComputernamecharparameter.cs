using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetComputernamecharparameter.htm
    public partial  class frmGetComputernamecharparameter:Form
    {
        public frmGetComputernamecharparameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetComputernamecharparameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetComputernamecharparameter";
            this.Text = "frmGetComputernamecharparameter";
            this.Load += new System.EventHandler(this.frmGetComputernamecharparameter_Load);
            this.ResumeLayout(false);

        }

        private void frmGetComputernamecharparameter_Load(object sender, EventArgs e)
        {

        }
    }
}
