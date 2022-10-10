using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0400__Exception_Throw
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Rethrowanexception.htm
    public partial  class frmRethrowanexception:Form
    {
        public frmRethrowanexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRethrowanexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRethrowanexception";
            this.Text = "frmRethrowanexception";
            this.Load += new System.EventHandler(this.frmRethrowanexception_Load);
            this.ResumeLayout(false);

        }

        private void frmRethrowanexception_Load(object sender, EventArgs e)
        {

        }
    }
}
