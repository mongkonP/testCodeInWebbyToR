using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0640__ErrorProvider
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/GetErrorMessagefromErrorProvider.htm
    public partial  class frmGetErrorMessagefromErrorProvider:Form
    {
        public frmGetErrorMessagefromErrorProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetErrorMessagefromErrorProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetErrorMessagefromErrorProvider";
            this.Text = "frmGetErrorMessagefromErrorProvider";
            this.Load += new System.EventHandler(this.frmGetErrorMessagefromErrorProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmGetErrorMessagefromErrorProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
