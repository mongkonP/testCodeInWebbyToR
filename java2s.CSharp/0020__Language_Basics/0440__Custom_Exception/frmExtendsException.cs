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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/ExtendsException.htm
    public partial  class frmExtendsException:Form
    {
        public frmExtendsException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtendsException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtendsException";
            this.Text = "frmExtendsException";
            this.Load += new System.EventHandler(this.frmExtendsException_Load);
            this.ResumeLayout(false);

        }

        private void frmExtendsException_Load(object sender, EventArgs e)
        {

        }
    }
}
