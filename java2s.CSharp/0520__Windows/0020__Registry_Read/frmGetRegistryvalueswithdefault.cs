using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0020__Registry_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetRegistryvalueswithdefault.htm
    public partial  class frmGetRegistryvalueswithdefault:Form
    {
        public frmGetRegistryvalueswithdefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetRegistryvalueswithdefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetRegistryvalueswithdefault";
            this.Text = "frmGetRegistryvalueswithdefault";
            this.Load += new System.EventHandler(this.frmGetRegistryvalueswithdefault_Load);
            this.ResumeLayout(false);

        }

        private void frmGetRegistryvalueswithdefault_Load(object sender, EventArgs e)
        {

        }
    }
}
