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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ToolbarStyles.htm
    public partial  class frmToolbarStyles:Form
    {
        public frmToolbarStyles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolbarStyles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolbarStyles";
            this.Text = "frmToolbarStyles";
            this.Load += new System.EventHandler(this.frmToolbarStyles_Load);
            this.ResumeLayout(false);

        }

        private void frmToolbarStyles_Load(object sender, EventArgs e)
        {

        }
    }
}
