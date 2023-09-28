using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0880__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DisplayMessageBoxinButtonevent.htm
    public partial  class frmDisplayMessageBoxinButtonevent:Form
    {
        public frmDisplayMessageBoxinButtonevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayMessageBoxinButtonevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayMessageBoxinButtonevent";
            this.Text = "frmDisplayMessageBoxinButtonevent";
            this.Load += new System.EventHandler(this.frmDisplayMessageBoxinButtonevent_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayMessageBoxinButtonevent_Load(object sender, EventArgs e)
        {

        }
    }
}
