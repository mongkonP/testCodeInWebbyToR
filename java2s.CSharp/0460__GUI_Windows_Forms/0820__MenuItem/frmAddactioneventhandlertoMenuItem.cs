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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddactioneventhandlertoMenuItem.htm
    public partial  class frmAddactioneventhandlertoMenuItem:Form
    {
        public frmAddactioneventhandlertoMenuItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddactioneventhandlertoMenuItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddactioneventhandlertoMenuItem";
            this.Text = "frmAddactioneventhandlertoMenuItem";
            this.Load += new System.EventHandler(this.frmAddactioneventhandlertoMenuItem_Load);
            this.ResumeLayout(false);

        }

        private void frmAddactioneventhandlertoMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
