using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0020__Access
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ReaddatafromAccessdatabase.htm
    public partial  class frmReaddatafromAccessdatabase:Form
    {
        public frmReaddatafromAccessdatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReaddatafromAccessdatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReaddatafromAccessdatabase";
            this.Text = "frmReaddatafromAccessdatabase";
            this.Load += new System.EventHandler(this.frmReaddatafromAccessdatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmReaddatafromAccessdatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
