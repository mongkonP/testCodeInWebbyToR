using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1080__Control_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Canceleatevent.htm
    public partial  class frmCanceleatevent:Form
    {
        public frmCanceleatevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCanceleatevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCanceleatevent";
            this.Text = "frmCanceleatevent";
            this.Load += new System.EventHandler(this.frmCanceleatevent_Load);
            this.ResumeLayout(false);

        }

        private void frmCanceleatevent_Load(object sender, EventArgs e)
        {

        }
    }
}
