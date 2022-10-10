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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewDrives.htm
    public partial  class frmListViewDrives:Form
    {
        public frmListViewDrives()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewDrives
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewDrives";
            this.Text = "frmListViewDrives";
            this.Load += new System.EventHandler(this.frmListViewDrives_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewDrives_Load(object sender, EventArgs e)
        {

        }
    }
}
