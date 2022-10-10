using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0720__FloatLayoutPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FloatLayoutPanelDemo.htm
    public partial  class frmFloatLayoutPanelDemo:Form
    {
        public frmFloatLayoutPanelDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFloatLayoutPanelDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFloatLayoutPanelDemo";
            this.Text = "frmFloatLayoutPanelDemo";
            this.Load += new System.EventHandler(this.frmFloatLayoutPanelDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmFloatLayoutPanelDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
