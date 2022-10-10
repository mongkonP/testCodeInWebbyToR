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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Buttonmouseevent.htm
    public partial  class frmButtonmouseevent:Form
    {
        public frmButtonmouseevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonmouseevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonmouseevent";
            this.Text = "frmButtonmouseevent";
            this.Load += new System.EventHandler(this.frmButtonmouseevent_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonmouseevent_Load(object sender, EventArgs e)
        {

        }
    }
}
