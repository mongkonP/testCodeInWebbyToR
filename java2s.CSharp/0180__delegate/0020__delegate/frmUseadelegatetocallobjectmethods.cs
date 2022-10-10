using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0020__delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Useadelegatetocallobjectmethods.htm
    public partial  class frmUseadelegatetocallobjectmethods:Form
    {
        public frmUseadelegatetocallobjectmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseadelegatetocallobjectmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseadelegatetocallobjectmethods";
            this.Text = "frmUseadelegatetocallobjectmethods";
            this.Load += new System.EventHandler(this.frmUseadelegatetocallobjectmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUseadelegatetocallobjectmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
