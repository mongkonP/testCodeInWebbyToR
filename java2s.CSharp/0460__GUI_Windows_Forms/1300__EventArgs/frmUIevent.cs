using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1300__EventArgs
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UIevent.htm
    public partial  class frmUIevent:Form
    {
        public frmUIevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUIevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUIevent";
            this.Text = "frmUIevent";
            this.Load += new System.EventHandler(this.frmUIevent_Load);
            this.ResumeLayout(false);

        }

        private void frmUIevent_Load(object sender, EventArgs e)
        {

        }
    }
}
