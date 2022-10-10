using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0220__SqlConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SettingConnectionPoolingOptions.htm
    public partial  class frmSettingConnectionPoolingOptions:Form
    {
        public frmSettingConnectionPoolingOptions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSettingConnectionPoolingOptions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSettingConnectionPoolingOptions";
            this.Text = "frmSettingConnectionPoolingOptions";
            this.Load += new System.EventHandler(this.frmSettingConnectionPoolingOptions_Load);
            this.ResumeLayout(false);

        }

        private void frmSettingConnectionPoolingOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
