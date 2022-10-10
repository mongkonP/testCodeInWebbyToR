using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1460__Thread_UI
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MutexandUI.htm
    public partial  class frmMutexandUI:Form
    {
        public frmMutexandUI()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMutexandUI
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMutexandUI";
            this.Text = "frmMutexandUI";
            this.Load += new System.EventHandler(this.frmMutexandUI_Load);
            this.ResumeLayout(false);

        }

        private void frmMutexandUI_Load(object sender, EventArgs e)
        {

        }
    }
}
