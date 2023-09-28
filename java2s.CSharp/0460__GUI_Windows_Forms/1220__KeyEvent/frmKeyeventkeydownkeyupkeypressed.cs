using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1220__KeyEvent
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Keyeventkeydownkeyupkeypressed.htm
    public partial  class frmKeyeventkeydownkeyupkeypressed:Form
    {
        public frmKeyeventkeydownkeyupkeypressed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmKeyeventkeydownkeyupkeypressed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmKeyeventkeydownkeyupkeypressed";
            this.Text = "frmKeyeventkeydownkeyupkeypressed";
            this.Load += new System.EventHandler(this.frmKeyeventkeydownkeyupkeypressed_Load);
            this.ResumeLayout(false);

        }

        private void frmKeyeventkeydownkeyupkeypressed_Load(object sender, EventArgs e)
        {

        }
    }
}
