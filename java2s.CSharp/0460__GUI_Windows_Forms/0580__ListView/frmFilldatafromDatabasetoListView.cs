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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FilldatafromDatabasetoListView.htm
    public partial  class frmFilldatafromDatabasetoListView:Form
    {
        public frmFilldatafromDatabasetoListView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFilldatafromDatabasetoListView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFilldatafromDatabasetoListView";
            this.Text = "frmFilldatafromDatabasetoListView";
            this.Load += new System.EventHandler(this.frmFilldatafromDatabasetoListView_Load);
            this.ResumeLayout(false);

        }

        private void frmFilldatafromDatabasetoListView_Load(object sender, EventArgs e)
        {

        }
    }
}
