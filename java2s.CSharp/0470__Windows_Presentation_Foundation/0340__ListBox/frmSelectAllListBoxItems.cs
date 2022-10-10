using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0340__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SelectAllListBoxItems.htm
    public partial  class frmSelectAllListBoxItems:Form
    {
        public frmSelectAllListBoxItems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectAllListBoxItems
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectAllListBoxItems";
            this.Text = "frmSelectAllListBoxItems";
            this.Load += new System.EventHandler(this.frmSelectAllListBoxItems_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectAllListBoxItems_Load(object sender, EventArgs e)
        {

        }
    }
}
