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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddImagetoToolBarButton.htm
    public partial  class frmAddImagetoToolBarButton:Form
    {
        public frmAddImagetoToolBarButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddImagetoToolBarButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddImagetoToolBarButton";
            this.Text = "frmAddImagetoToolBarButton";
            this.Load += new System.EventHandler(this.frmAddImagetoToolBarButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddImagetoToolBarButton_Load(object sender, EventArgs e)
        {

        }
    }
}
