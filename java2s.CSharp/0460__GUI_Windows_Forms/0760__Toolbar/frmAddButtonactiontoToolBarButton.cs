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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddButtonactiontoToolBarButton.htm
    public partial  class frmAddButtonactiontoToolBarButton:Form
    {
        public frmAddButtonactiontoToolBarButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddButtonactiontoToolBarButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddButtonactiontoToolBarButton";
            this.Text = "frmAddButtonactiontoToolBarButton";
            this.Load += new System.EventHandler(this.frmAddButtonactiontoToolBarButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddButtonactiontoToolBarButton_Load(object sender, EventArgs e)
        {

        }
    }
}
