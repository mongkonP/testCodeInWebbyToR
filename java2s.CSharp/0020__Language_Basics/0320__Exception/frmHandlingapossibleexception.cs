using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0320__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Handlingapossibleexception.htm
    public partial  class frmHandlingapossibleexception:Form
    {
        public frmHandlingapossibleexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlingapossibleexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlingapossibleexception";
            this.Text = "frmHandlingapossibleexception";
            this.Load += new System.EventHandler(this.frmHandlingapossibleexception_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlingapossibleexception_Load(object sender, EventArgs e)
        {

        }
    }
}
