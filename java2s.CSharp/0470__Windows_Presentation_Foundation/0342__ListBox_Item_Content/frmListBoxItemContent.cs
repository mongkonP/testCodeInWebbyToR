using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0342__ListBox_Item_Content
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListBoxItemContent.htm
    public partial  class frmListBoxItemContent:Form
    {
        public frmListBoxItemContent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxItemContent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxItemContent";
            this.Text = "frmListBoxItemContent";
            this.Load += new System.EventHandler(this.frmListBoxItemContent_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxItemContent_Load(object sender, EventArgs e)
        {

        }
    }
}
