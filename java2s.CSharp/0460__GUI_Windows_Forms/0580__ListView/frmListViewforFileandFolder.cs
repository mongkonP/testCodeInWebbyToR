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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewforFileandFolder.htm
    public partial  class frmListViewforFileandFolder:Form
    {
        public frmListViewforFileandFolder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewforFileandFolder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewforFileandFolder";
            this.Text = "frmListViewforFileandFolder";
            this.Load += new System.EventHandler(this.frmListViewforFileandFolder_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewforFileandFolder_Load(object sender, EventArgs e)
        {

        }
    }
}
