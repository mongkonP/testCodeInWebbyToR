using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0140__Label
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/GenericeventforaLabel.htm
    public partial  class frmGenericeventforaLabel:Form
    {
        public frmGenericeventforaLabel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericeventforaLabel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericeventforaLabel";
            this.Text = "frmGenericeventforaLabel";
            this.Load += new System.EventHandler(this.frmGenericeventforaLabel_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericeventforaLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
