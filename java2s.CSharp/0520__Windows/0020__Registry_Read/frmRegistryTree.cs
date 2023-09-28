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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/RegistryTree.htm
    public partial  class frmRegistryTree:Form
    {
        public frmRegistryTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegistryTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegistryTree";
            this.Text = "frmRegistryTree";
            this.Load += new System.EventHandler(this.frmRegistryTree_Load);
            this.ResumeLayout(false);

        }

        private void frmRegistryTree_Load(object sender, EventArgs e)
        {

        }
    }
}
