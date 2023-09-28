using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ImagewithContextMenu.htm
    public partial  class frmImagewithContextMenu:Form
    {
        public frmImagewithContextMenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImagewithContextMenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImagewithContextMenu";
            this.Text = "frmImagewithContextMenu";
            this.Load += new System.EventHandler(this.frmImagewithContextMenu_Load);
            this.ResumeLayout(false);

        }

        private void frmImagewithContextMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
