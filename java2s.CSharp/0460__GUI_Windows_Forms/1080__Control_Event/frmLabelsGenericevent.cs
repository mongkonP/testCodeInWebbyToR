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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/LabelsGenericevent.htm
    public partial  class frmLabelsGenericevent:Form
    {
        public frmLabelsGenericevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLabelsGenericevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLabelsGenericevent";
            this.Text = "frmLabelsGenericevent";
            this.Load += new System.EventHandler(this.frmLabelsGenericevent_Load);
            this.ResumeLayout(false);

        }

        private void frmLabelsGenericevent_Load(object sender, EventArgs e)
        {

        }
    }
}
