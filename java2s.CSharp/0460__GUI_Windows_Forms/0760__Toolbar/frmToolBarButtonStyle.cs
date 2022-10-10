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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ToolBarButtonStyle.htm
    public partial  class frmToolBarButtonStyle:Form
    {
        public frmToolBarButtonStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolBarButtonStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolBarButtonStyle";
            this.Text = "frmToolBarButtonStyle";
            this.Load += new System.EventHandler(this.frmToolBarButtonStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmToolBarButtonStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
