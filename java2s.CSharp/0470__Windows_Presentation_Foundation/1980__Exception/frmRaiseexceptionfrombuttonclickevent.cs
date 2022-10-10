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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Raiseexceptionfrombuttonclickevent.htm
    public partial  class frmRaiseexceptionfrombuttonclickevent:Form
    {
        public frmRaiseexceptionfrombuttonclickevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRaiseexceptionfrombuttonclickevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRaiseexceptionfrombuttonclickevent";
            this.Text = "frmRaiseexceptionfrombuttonclickevent";
            this.Load += new System.EventHandler(this.frmRaiseexceptionfrombuttonclickevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRaiseexceptionfrombuttonclickevent_Load(object sender, EventArgs e)
        {

        }
    }
}
