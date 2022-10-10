using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0160__OleDbDataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdatingaDataSource.htm
    public partial  class frmUpdatingaDataSource:Form
    {
        public frmUpdatingaDataSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatingaDataSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatingaDataSource";
            this.Text = "frmUpdatingaDataSource";
            this.Load += new System.EventHandler(this.frmUpdatingaDataSource_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatingaDataSource_Load(object sender, EventArgs e)
        {

        }
    }
}
