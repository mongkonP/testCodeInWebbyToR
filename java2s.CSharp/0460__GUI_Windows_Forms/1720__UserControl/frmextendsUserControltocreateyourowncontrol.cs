using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1720__UserControl
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/extendsUserControltocreateyourowncontrol.htm
    public partial  class frmextendsUserControltocreateyourowncontrol:Form
    {
        public frmextendsUserControltocreateyourowncontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsUserControltocreateyourowncontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsUserControltocreateyourowncontrol";
            this.Text = "frmextendsUserControltocreateyourowncontrol";
            this.Load += new System.EventHandler(this.frmextendsUserControltocreateyourowncontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsUserControltocreateyourowncontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
