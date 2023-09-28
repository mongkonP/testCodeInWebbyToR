using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0580__ListView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewSorter.htm
    public partial  class frmListViewSorter:Form
    {
        public frmListViewSorter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewSorter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewSorter";
            this.Text = "frmListViewSorter";
            this.Load += new System.EventHandler(this.frmListViewSorter_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewSorter_Load(object sender, EventArgs e)
        {

        }
    }
}
