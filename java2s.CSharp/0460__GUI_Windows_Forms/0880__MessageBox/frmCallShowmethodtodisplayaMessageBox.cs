using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0880__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CallShowmethodtodisplayaMessageBox.htm
    public partial  class frmCallShowmethodtodisplayaMessageBox:Form
    {
        public frmCallShowmethodtodisplayaMessageBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallShowmethodtodisplayaMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallShowmethodtodisplayaMessageBox";
            this.Text = "frmCallShowmethodtodisplayaMessageBox";
            this.Load += new System.EventHandler(this.frmCallShowmethodtodisplayaMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void frmCallShowmethodtodisplayaMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
