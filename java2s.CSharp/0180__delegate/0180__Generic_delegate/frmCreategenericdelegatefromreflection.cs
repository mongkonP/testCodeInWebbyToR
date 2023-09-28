using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0180__Generic_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Creategenericdelegatefromreflection.htm
    public partial  class frmCreategenericdelegatefromreflection:Form
    {
        public frmCreategenericdelegatefromreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreategenericdelegatefromreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreategenericdelegatefromreflection";
            this.Text = "frmCreategenericdelegatefromreflection";
            this.Load += new System.EventHandler(this.frmCreategenericdelegatefromreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmCreategenericdelegatefromreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
