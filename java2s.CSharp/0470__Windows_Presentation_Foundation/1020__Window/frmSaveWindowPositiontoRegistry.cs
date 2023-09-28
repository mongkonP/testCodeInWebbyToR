using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SaveWindowPositiontoRegistry.htm
    public partial  class frmSaveWindowPositiontoRegistry:Form
    {
        public frmSaveWindowPositiontoRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveWindowPositiontoRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveWindowPositiontoRegistry";
            this.Text = "frmSaveWindowPositiontoRegistry";
            this.Load += new System.EventHandler(this.frmSaveWindowPositiontoRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveWindowPositiontoRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
