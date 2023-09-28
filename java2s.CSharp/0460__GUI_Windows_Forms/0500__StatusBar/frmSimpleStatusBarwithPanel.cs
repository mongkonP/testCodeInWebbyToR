using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0500__StatusBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpleStatusBarwithPanel.htm
    public partial  class frmSimpleStatusBarwithPanel:Form
    {
        public frmSimpleStatusBarwithPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleStatusBarwithPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleStatusBarwithPanel";
            this.Text = "frmSimpleStatusBarwithPanel";
            this.Load += new System.EventHandler(this.frmSimpleStatusBarwithPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleStatusBarwithPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
