using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0060__Form_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Formmousemoveevent.htm
    public partial  class frmFormmousemoveevent:Form
    {
        public frmFormmousemoveevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormmousemoveevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormmousemoveevent";
            this.Text = "frmFormmousemoveevent";
            this.Load += new System.EventHandler(this.frmFormmousemoveevent_Load);
            this.ResumeLayout(false);

        }

        private void frmFormmousemoveevent_Load(object sender, EventArgs e)
        {

        }
    }
}
