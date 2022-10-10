using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0020__AppDomain
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Unloadinganapplicationdomain.htm
    public partial  class frmUnloadinganapplicationdomain:Form
    {
        public frmUnloadinganapplicationdomain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnloadinganapplicationdomain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnloadinganapplicationdomain";
            this.Text = "frmUnloadinganapplicationdomain";
            this.Load += new System.EventHandler(this.frmUnloadinganapplicationdomain_Load);
            this.ResumeLayout(false);

        }

        private void frmUnloadinganapplicationdomain_Load(object sender, EventArgs e)
        {

        }
    }
}
