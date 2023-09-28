using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0780__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ContextMenuDemo.htm
    public partial  class frmContextMenuDemo:Form
    {
        public frmContextMenuDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContextMenuDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContextMenuDemo";
            this.Text = "frmContextMenuDemo";
            this.Load += new System.EventHandler(this.frmContextMenuDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmContextMenuDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
