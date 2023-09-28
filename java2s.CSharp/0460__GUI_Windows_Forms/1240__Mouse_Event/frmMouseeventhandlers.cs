using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1240__Mouse_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Mouseeventhandlers.htm
    public partial  class frmMouseeventhandlers:Form
    {
        public frmMouseeventhandlers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMouseeventhandlers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMouseeventhandlers";
            this.Text = "frmMouseeventhandlers";
            this.Load += new System.EventHandler(this.frmMouseeventhandlers_Load);
            this.ResumeLayout(false);

        }

        private void frmMouseeventhandlers_Load(object sender, EventArgs e)
        {

        }
    }
}
