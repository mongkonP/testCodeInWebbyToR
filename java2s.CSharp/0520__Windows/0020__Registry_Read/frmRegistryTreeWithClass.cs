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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/RegistryTreeWithClass.htm
    public partial  class frmRegistryTreeWithClass:Form
    {
        public frmRegistryTreeWithClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegistryTreeWithClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegistryTreeWithClass";
            this.Text = "frmRegistryTreeWithClass";
            this.Load += new System.EventHandler(this.frmRegistryTreeWithClass_Load);
            this.ResumeLayout(false);

        }

        private void frmRegistryTreeWithClass_Load(object sender, EventArgs e)
        {

        }
    }
}
