using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0140__Return_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Returndelegatefromamethod.htm
    public partial  class frmReturndelegatefromamethod:Form
    {
        public frmReturndelegatefromamethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturndelegatefromamethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturndelegatefromamethod";
            this.Text = "frmReturndelegatefromamethod";
            this.Load += new System.EventHandler(this.frmReturndelegatefromamethod_Load);
            this.ResumeLayout(false);

        }

        private void frmReturndelegatefromamethod_Load(object sender, EventArgs e)
        {

        }
    }
}
