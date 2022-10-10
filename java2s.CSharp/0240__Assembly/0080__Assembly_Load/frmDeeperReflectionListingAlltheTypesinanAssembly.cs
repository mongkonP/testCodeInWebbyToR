using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/DeeperReflectionListingAlltheTypesinanAssembly.htm
    public partial  class frmDeeperReflectionListingAlltheTypesinanAssembly:Form
    {
        public frmDeeperReflectionListingAlltheTypesinanAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeeperReflectionListingAlltheTypesinanAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeeperReflectionListingAlltheTypesinanAssembly";
            this.Text = "frmDeeperReflectionListingAlltheTypesinanAssembly";
            this.Load += new System.EventHandler(this.frmDeeperReflectionListingAlltheTypesinanAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmDeeperReflectionListingAlltheTypesinanAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
