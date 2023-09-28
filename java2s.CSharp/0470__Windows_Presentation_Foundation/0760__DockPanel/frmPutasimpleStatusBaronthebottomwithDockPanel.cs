using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0760__DockPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PutasimpleStatusBaronthebottomwithDockPanel.htm
    public partial  class frmPutasimpleStatusBaronthebottomwithDockPanel:Form
    {
        public frmPutasimpleStatusBaronthebottomwithDockPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPutasimpleStatusBaronthebottomwithDockPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPutasimpleStatusBaronthebottomwithDockPanel";
            this.Text = "frmPutasimpleStatusBaronthebottomwithDockPanel";
            this.Load += new System.EventHandler(this.frmPutasimpleStatusBaronthebottomwithDockPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmPutasimpleStatusBaronthebottomwithDockPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
