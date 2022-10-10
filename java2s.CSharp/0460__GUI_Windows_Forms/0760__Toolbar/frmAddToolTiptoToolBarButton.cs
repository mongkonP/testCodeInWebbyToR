using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0760__Toolbar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddToolTiptoToolBarButton.htm
    public partial  class frmAddToolTiptoToolBarButton:Form
    {
        public frmAddToolTiptoToolBarButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddToolTiptoToolBarButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddToolTiptoToolBarButton";
            this.Text = "frmAddToolTiptoToolBarButton";
            this.Load += new System.EventHandler(this.frmAddToolTiptoToolBarButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddToolTiptoToolBarButton_Load(object sender, EventArgs e)
        {

        }
    }
}
