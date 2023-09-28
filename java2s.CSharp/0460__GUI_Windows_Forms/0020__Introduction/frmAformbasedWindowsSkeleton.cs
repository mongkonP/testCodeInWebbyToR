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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AformbasedWindowsSkeleton.htm
    public partial  class frmAformbasedWindowsSkeleton:Form
    {
        public frmAformbasedWindowsSkeleton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAformbasedWindowsSkeleton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAformbasedWindowsSkeleton";
            this.Text = "frmAformbasedWindowsSkeleton";
            this.Load += new System.EventHandler(this.frmAformbasedWindowsSkeleton_Load);
            this.ResumeLayout(false);

        }

        private void frmAformbasedWindowsSkeleton_Load(object sender, EventArgs e)
        {

        }
    }
}
