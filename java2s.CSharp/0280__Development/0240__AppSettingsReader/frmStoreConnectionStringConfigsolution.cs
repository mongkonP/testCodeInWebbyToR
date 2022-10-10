using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0240__AppSettingsReader
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/StoreConnectionStringConfigsolution.htm
    public partial  class frmStoreConnectionStringConfigsolution:Form
    {
        public frmStoreConnectionStringConfigsolution()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStoreConnectionStringConfigsolution
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStoreConnectionStringConfigsolution";
            this.Text = "frmStoreConnectionStringConfigsolution";
            this.Load += new System.EventHandler(this.frmStoreConnectionStringConfigsolution_Load);
            this.ResumeLayout(false);

        }

        private void frmStoreConnectionStringConfigsolution_Load(object sender, EventArgs e)
        {

        }
    }
}
