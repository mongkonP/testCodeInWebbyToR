using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThrowExceptionfrombuttonclickaction.htm
    public partial  class frmThrowExceptionfrombuttonclickaction:Form
    {
        public frmThrowExceptionfrombuttonclickaction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowExceptionfrombuttonclickaction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowExceptionfrombuttonclickaction";
            this.Text = "frmThrowExceptionfrombuttonclickaction";
            this.Load += new System.EventHandler(this.frmThrowExceptionfrombuttonclickaction_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowExceptionfrombuttonclickaction_Load(object sender, EventArgs e)
        {

        }
    }
}
