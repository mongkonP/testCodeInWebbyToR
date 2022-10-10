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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Docklistboxatleftofpanel.htm
    public partial  class frmDocklistboxatleftofpanel:Form
    {
        public frmDocklistboxatleftofpanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDocklistboxatleftofpanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDocklistboxatleftofpanel";
            this.Text = "frmDocklistboxatleftofpanel";
            this.Load += new System.EventHandler(this.frmDocklistboxatleftofpanel_Load);
            this.ResumeLayout(false);

        }

        private void frmDocklistboxatleftofpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
