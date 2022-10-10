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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormMouseUpevent.htm
    public partial  class frmFormMouseUpevent:Form
    {
        public frmFormMouseUpevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormMouseUpevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormMouseUpevent";
            this.Text = "frmFormMouseUpevent";
            this.Load += new System.EventHandler(this.frmFormMouseUpevent_Load);
            this.ResumeLayout(false);

        }

        private void frmFormMouseUpevent_Load(object sender, EventArgs e)
        {

        }
    }
}
