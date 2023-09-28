using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0800__ContextMenu_Popup_Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Formpopupmenu.htm
    public partial  class frmFormpopupmenu:Form
    {
        public frmFormpopupmenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormpopupmenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormpopupmenu";
            this.Text = "frmFormpopupmenu";
            this.Load += new System.EventHandler(this.frmFormpopupmenu_Load);
            this.ResumeLayout(false);

        }

        private void frmFormpopupmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
