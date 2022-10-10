using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0420__Predefined_Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/HandleArgumentOutOfRangeException.htm
    public partial  class frmHandleArgumentOutOfRangeException:Form
    {
        public frmHandleArgumentOutOfRangeException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandleArgumentOutOfRangeException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandleArgumentOutOfRangeException";
            this.Text = "frmHandleArgumentOutOfRangeException";
            this.Load += new System.EventHandler(this.frmHandleArgumentOutOfRangeException_Load);
            this.ResumeLayout(false);

        }

        private void frmHandleArgumentOutOfRangeException_Load(object sender, EventArgs e)
        {

        }
    }
}
