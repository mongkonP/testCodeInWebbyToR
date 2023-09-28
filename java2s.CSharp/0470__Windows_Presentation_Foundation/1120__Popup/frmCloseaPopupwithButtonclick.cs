using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1120__Popup
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CloseaPopupwithButtonclick.htm
    public partial  class frmCloseaPopupwithButtonclick:Form
    {
        public frmCloseaPopupwithButtonclick()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCloseaPopupwithButtonclick
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCloseaPopupwithButtonclick";
            this.Text = "frmCloseaPopupwithButtonclick";
            this.Load += new System.EventHandler(this.frmCloseaPopupwithButtonclick_Load);
            this.ResumeLayout(false);

        }

        private void frmCloseaPopupwithButtonclick_Load(object sender, EventArgs e)
        {

        }
    }
}
