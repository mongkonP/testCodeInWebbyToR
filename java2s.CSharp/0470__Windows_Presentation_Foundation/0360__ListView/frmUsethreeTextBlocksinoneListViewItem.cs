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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsethreeTextBlocksinoneListViewItem.htm
    public partial  class frmUsethreeTextBlocksinoneListViewItem:Form
    {
        public frmUsethreeTextBlocksinoneListViewItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethreeTextBlocksinoneListViewItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethreeTextBlocksinoneListViewItem";
            this.Text = "frmUsethreeTextBlocksinoneListViewItem";
            this.Load += new System.EventHandler(this.frmUsethreeTextBlocksinoneListViewItem_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethreeTextBlocksinoneListViewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
