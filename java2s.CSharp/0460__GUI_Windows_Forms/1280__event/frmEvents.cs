using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Events.htm
    public partial  class frmEvents:Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEvents";
            this.Text = "frmEvents";
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
