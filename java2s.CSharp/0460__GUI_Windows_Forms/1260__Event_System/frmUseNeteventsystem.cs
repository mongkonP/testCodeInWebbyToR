using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1260__Event_System
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseNeteventsystem.htm
    public partial  class frmUseNeteventsystem:Form
    {
        public frmUseNeteventsystem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseNeteventsystem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseNeteventsystem";
            this.Text = "frmUseNeteventsystem";
            this.Load += new System.EventHandler(this.frmUseNeteventsystem_Load);
            this.ResumeLayout(false);

        }

        private void frmUseNeteventsystem_Load(object sender, EventArgs e)
        {

        }
    }
}
