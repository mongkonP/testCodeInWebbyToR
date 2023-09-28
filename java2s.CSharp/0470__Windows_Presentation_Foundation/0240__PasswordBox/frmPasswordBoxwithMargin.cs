using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0240__PasswordBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PasswordBoxwithMargin.htm
    public partial  class frmPasswordBoxwithMargin:Form
    {
        public frmPasswordBoxwithMargin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPasswordBoxwithMargin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPasswordBoxwithMargin";
            this.Text = "frmPasswordBoxwithMargin";
            this.Load += new System.EventHandler(this.frmPasswordBoxwithMargin_Load);
            this.ResumeLayout(false);

        }

        private void frmPasswordBoxwithMargin_Load(object sender, EventArgs e)
        {

        }
    }
}
