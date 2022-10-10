using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0740__TableLayoutPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TableLayoutPanelDemo.htm
    public partial  class frmTableLayoutPanelDemo:Form
    {
        public frmTableLayoutPanelDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTableLayoutPanelDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTableLayoutPanelDemo";
            this.Text = "frmTableLayoutPanelDemo";
            this.Load += new System.EventHandler(this.frmTableLayoutPanelDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmTableLayoutPanelDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
