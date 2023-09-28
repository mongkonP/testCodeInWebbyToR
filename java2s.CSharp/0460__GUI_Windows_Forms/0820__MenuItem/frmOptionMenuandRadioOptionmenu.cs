using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0820__MenuItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OptionMenuandRadioOptionmenu.htm
    public partial  class frmOptionMenuandRadioOptionmenu:Form
    {
        public frmOptionMenuandRadioOptionmenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOptionMenuandRadioOptionmenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOptionMenuandRadioOptionmenu";
            this.Text = "frmOptionMenuandRadioOptionmenu";
            this.Load += new System.EventHandler(this.frmOptionMenuandRadioOptionmenu_Load);
            this.ResumeLayout(false);

        }

        private void frmOptionMenuandRadioOptionmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
