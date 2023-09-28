using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0160__Host
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Listvirtualhosts.htm
    public partial  class frmListvirtualhosts:Form
    {
        public frmListvirtualhosts()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListvirtualhosts
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListvirtualhosts";
            this.Text = "frmListvirtualhosts";
            this.Load += new System.EventHandler(this.frmListvirtualhosts_Load);
            this.ResumeLayout(false);

        }

        private void frmListvirtualhosts_Load(object sender, EventArgs e)
        {

        }
    }
}
