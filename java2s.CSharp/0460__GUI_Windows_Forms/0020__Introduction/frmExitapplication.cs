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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Exitapplication.htm
    public partial  class frmExitapplication:Form
    {
        public frmExitapplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExitapplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExitapplication";
            this.Text = "frmExitapplication";
            this.Load += new System.EventHandler(this.frmExitapplication_Load);
            this.ResumeLayout(false);

        }

        private void frmExitapplication_Load(object sender, EventArgs e)
        {

        }
    }
}
