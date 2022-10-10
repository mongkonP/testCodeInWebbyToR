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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MultithreadinginWindowsForms.htm
    public partial  class frmMultithreadinginWindowsForms:Form
    {
        public frmMultithreadinginWindowsForms()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultithreadinginWindowsForms
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultithreadinginWindowsForms";
            this.Text = "frmMultithreadinginWindowsForms";
            this.Load += new System.EventHandler(this.frmMultithreadinginWindowsForms_Load);
            this.ResumeLayout(false);

        }

        private void frmMultithreadinginWindowsForms_Load(object sender, EventArgs e)
        {

        }
    }
}
