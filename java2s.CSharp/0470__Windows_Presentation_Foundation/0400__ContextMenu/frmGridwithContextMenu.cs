using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0400__ContextMenu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridwithContextMenu.htm
    public partial  class frmGridwithContextMenu:Form
    {
        public frmGridwithContextMenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridwithContextMenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridwithContextMenu";
            this.Text = "frmGridwithContextMenu";
            this.Load += new System.EventHandler(this.frmGridwithContextMenu_Load);
            this.ResumeLayout(false);

        }

        private void frmGridwithContextMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
