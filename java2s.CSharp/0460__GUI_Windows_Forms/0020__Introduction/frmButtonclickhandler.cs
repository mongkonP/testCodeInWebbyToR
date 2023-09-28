using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Buttonclickhandler.htm
    public partial  class frmButtonclickhandler:Form
    {
        public frmButtonclickhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonclickhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonclickhandler";
            this.Text = "frmButtonclickhandler";
            this.Load += new System.EventHandler(this.frmButtonclickhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonclickhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
