using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CalShowmethodtodisplayaform.htm
    public partial  class frmCalShowmethodtodisplayaform:Form
    {
        public frmCalShowmethodtodisplayaform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalShowmethodtodisplayaform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCalShowmethodtodisplayaform";
            this.Text = "frmCalShowmethodtodisplayaform";
            this.Load += new System.EventHandler(this.frmCalShowmethodtodisplayaform_Load);
            this.ResumeLayout(false);

        }

        private void frmCalShowmethodtodisplayaform_Load(object sender, EventArgs e)
        {

        }
    }
}
