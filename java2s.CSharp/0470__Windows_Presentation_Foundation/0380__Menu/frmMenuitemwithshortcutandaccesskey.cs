using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0380__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Menuitemwithshortcutandaccesskey.htm
    public partial  class frmMenuitemwithshortcutandaccesskey:Form
    {
        public frmMenuitemwithshortcutandaccesskey()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMenuitemwithshortcutandaccesskey
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMenuitemwithshortcutandaccesskey";
            this.Text = "frmMenuitemwithshortcutandaccesskey";
            this.Load += new System.EventHandler(this.frmMenuitemwithshortcutandaccesskey_Load);
            this.ResumeLayout(false);

        }

        private void frmMenuitemwithshortcutandaccesskey_Load(object sender, EventArgs e)
        {

        }
    }
}
