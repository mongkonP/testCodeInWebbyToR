using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Interfaces.htm
    public partial  class frmInterfaces:Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfaces";
            this.Text = "frmInterfaces";
            this.Load += new System.EventHandler(this.frmInterfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
