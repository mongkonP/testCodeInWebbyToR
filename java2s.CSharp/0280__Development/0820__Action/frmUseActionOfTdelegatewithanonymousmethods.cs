using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0820__Action
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UseActionOfTdelegatewithanonymousmethods.htm
    public partial  class frmUseActionOfTdelegatewithanonymousmethods:Form
    {
        public frmUseActionOfTdelegatewithanonymousmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseActionOfTdelegatewithanonymousmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseActionOfTdelegatewithanonymousmethods";
            this.Text = "frmUseActionOfTdelegatewithanonymousmethods";
            this.Load += new System.EventHandler(this.frmUseActionOfTdelegatewithanonymousmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUseActionOfTdelegatewithanonymousmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
