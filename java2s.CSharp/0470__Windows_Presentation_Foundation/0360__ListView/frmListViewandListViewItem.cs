using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0360__ListView
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListViewandListViewItem.htm
    public partial  class frmListViewandListViewItem:Form
    {
        public frmListViewandListViewItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewandListViewItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewandListViewItem";
            this.Text = "frmListViewandListViewItem";
            this.Load += new System.EventHandler(this.frmListViewandListViewItem_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewandListViewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
