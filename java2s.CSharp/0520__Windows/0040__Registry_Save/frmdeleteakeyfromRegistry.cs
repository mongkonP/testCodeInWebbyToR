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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/deleteakeyfromRegistry.htm
    public partial  class frmdeleteakeyfromRegistry:Form
    {
        public frmdeleteakeyfromRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdeleteakeyfromRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdeleteakeyfromRegistry";
            this.Text = "frmdeleteakeyfromRegistry";
            this.Load += new System.EventHandler(this.frmdeleteakeyfromRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmdeleteakeyfromRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
