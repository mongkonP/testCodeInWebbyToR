using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0040__Registry_Save
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/DeleteasettinginRegistry.htm
    public partial  class frmDeleteasettinginRegistry:Form
    {
        public frmDeleteasettinginRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeleteasettinginRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeleteasettinginRegistry";
            this.Text = "frmDeleteasettinginRegistry";
            this.Load += new System.EventHandler(this.frmDeleteasettinginRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmDeleteasettinginRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
