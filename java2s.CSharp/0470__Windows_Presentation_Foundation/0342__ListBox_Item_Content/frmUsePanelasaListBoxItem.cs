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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsePanelasaListBoxItem.htm
    public partial  class frmUsePanelasaListBoxItem:Form
    {
        public frmUsePanelasaListBoxItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsePanelasaListBoxItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsePanelasaListBoxItem";
            this.Text = "frmUsePanelasaListBoxItem";
            this.Load += new System.EventHandler(this.frmUsePanelasaListBoxItem_Load);
            this.ResumeLayout(false);

        }

        private void frmUsePanelasaListBoxItem_Load(object sender, EventArgs e)
        {

        }
    }
}
