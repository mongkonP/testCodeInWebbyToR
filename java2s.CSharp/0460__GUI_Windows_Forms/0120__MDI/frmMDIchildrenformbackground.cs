using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0120__MDI
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MDIchildrenformbackground.htm
    public partial  class frmMDIchildrenformbackground:Form
    {
        public frmMDIchildrenformbackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMDIchildrenformbackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMDIchildrenformbackground";
            this.Text = "frmMDIchildrenformbackground";
            this.Load += new System.EventHandler(this.frmMDIchildrenformbackground_Load);
            this.ResumeLayout(false);

        }

        private void frmMDIchildrenformbackground_Load(object sender, EventArgs e)
        {

        }
    }
}
