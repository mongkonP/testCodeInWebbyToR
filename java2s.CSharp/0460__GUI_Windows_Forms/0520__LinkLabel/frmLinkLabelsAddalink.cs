using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0520__LinkLabel
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/LinkLabelsAddalink.htm
    public partial  class frmLinkLabelsAddalink:Form
    {
        public frmLinkLabelsAddalink()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinkLabelsAddalink
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinkLabelsAddalink";
            this.Text = "frmLinkLabelsAddalink";
            this.Load += new System.EventHandler(this.frmLinkLabelsAddalink_Load);
            this.ResumeLayout(false);

        }

        private void frmLinkLabelsAddalink_Load(object sender, EventArgs e)
        {

        }
    }
}
