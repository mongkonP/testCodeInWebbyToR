using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0540__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListBoxItemsAddaRange.htm
    public partial  class frmListBoxItemsAddaRange:Form
    {
        public frmListBoxItemsAddaRange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxItemsAddaRange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxItemsAddaRange";
            this.Text = "frmListBoxItemsAddaRange";
            this.Load += new System.EventHandler(this.frmListBoxItemsAddaRange_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxItemsAddaRange_Load(object sender, EventArgs e)
        {

        }
    }
}
