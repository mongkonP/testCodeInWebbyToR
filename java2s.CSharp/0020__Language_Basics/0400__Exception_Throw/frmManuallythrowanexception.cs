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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Manuallythrowanexception.htm
    public partial  class frmManuallythrowanexception:Form
    {
        public frmManuallythrowanexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManuallythrowanexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManuallythrowanexception";
            this.Text = "frmManuallythrowanexception";
            this.Load += new System.EventHandler(this.frmManuallythrowanexception_Load);
            this.ResumeLayout(false);

        }

        private void frmManuallythrowanexception_Load(object sender, EventArgs e)
        {

        }
    }
}
