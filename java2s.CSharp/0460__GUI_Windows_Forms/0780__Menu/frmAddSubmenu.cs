using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0780__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddSubmenu.htm
    public partial  class frmAddSubmenu:Form
    {
        public frmAddSubmenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddSubmenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddSubmenu";
            this.Text = "frmAddSubmenu";
            this.Load += new System.EventHandler(this.frmAddSubmenu_Load);
            this.ResumeLayout(false);

        }

        private void frmAddSubmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
