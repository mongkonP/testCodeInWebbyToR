using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SetLabeltextinabuttonclickevent.htm
    public partial  class frmSetLabeltextinabuttonclickevent:Form
    {
        public frmSetLabeltextinabuttonclickevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetLabeltextinabuttonclickevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetLabeltextinabuttonclickevent";
            this.Text = "frmSetLabeltextinabuttonclickevent";
            this.Load += new System.EventHandler(this.frmSetLabeltextinabuttonclickevent_Load);
            this.ResumeLayout(false);

        }

        private void frmSetLabeltextinabuttonclickevent_Load(object sender, EventArgs e)
        {

        }
    }
}
