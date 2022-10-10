using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/WorkingwithStrings.htm
    public partial  class frmWorkingwithStrings:Form
    {
        public frmWorkingwithStrings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWorkingwithStrings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWorkingwithStrings";
            this.Text = "frmWorkingwithStrings";
            this.Load += new System.EventHandler(this.frmWorkingwithStrings_Load);
            this.ResumeLayout(false);

        }

        private void frmWorkingwithStrings_Load(object sender, EventArgs e)
        {

        }
    }
}
