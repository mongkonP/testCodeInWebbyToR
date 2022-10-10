using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0600__ListViewItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CreateaListViewItemandaddittoListView.htm
    public partial  class frmCreateaListViewItemandaddittoListView:Form
    {
        public frmCreateaListViewItemandaddittoListView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaListViewItemandaddittoListView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaListViewItemandaddittoListView";
            this.Text = "frmCreateaListViewItemandaddittoListView";
            this.Load += new System.EventHandler(this.frmCreateaListViewItemandaddittoListView_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaListViewItemandaddittoListView_Load(object sender, EventArgs e)
        {

        }
    }
}
