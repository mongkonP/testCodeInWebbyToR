using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0060__Form_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Paintevent.htm
    public partial  class frmPaintevent:Form
    {
        public frmPaintevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPaintevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPaintevent";
            this.Text = "frmPaintevent";
            this.Load += new System.EventHandler(this.frmPaintevent_Load);
            this.ResumeLayout(false);

        }

        private void frmPaintevent_Load(object sender, EventArgs e)
        {

        }
    }
}
