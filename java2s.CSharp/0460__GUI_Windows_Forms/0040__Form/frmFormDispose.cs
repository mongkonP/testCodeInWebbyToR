using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormDispose.htm
    public partial  class frmFormDispose:Form
    {
        public frmFormDispose()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormDispose
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormDispose";
            this.Text = "frmFormDispose";
            this.Load += new System.EventHandler(this.frmFormDispose_Load);
            this.ResumeLayout(false);

        }

        private void frmFormDispose_Load(object sender, EventArgs e)
        {

        }
    }
}
