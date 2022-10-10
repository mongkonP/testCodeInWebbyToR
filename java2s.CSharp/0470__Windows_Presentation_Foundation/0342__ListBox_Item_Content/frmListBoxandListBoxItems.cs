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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListBoxandListBoxItems.htm
    public partial  class frmListBoxandListBoxItems:Form
    {
        public frmListBoxandListBoxItems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxandListBoxItems
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxandListBoxItems";
            this.Text = "frmListBoxandListBoxItems";
            this.Load += new System.EventHandler(this.frmListBoxandListBoxItems_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxandListBoxItems_Load(object sender, EventArgs e)
        {

        }
    }
}
