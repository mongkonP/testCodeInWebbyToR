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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Anobjectinanotherapplicationdomain.htm
    public partial  class frmAnobjectinanotherapplicationdomain:Form
    {
        public frmAnobjectinanotherapplicationdomain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnobjectinanotherapplicationdomain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnobjectinanotherapplicationdomain";
            this.Text = "frmAnobjectinanotherapplicationdomain";
            this.Load += new System.EventHandler(this.frmAnobjectinanotherapplicationdomain_Load);
            this.ResumeLayout(false);

        }

        private void frmAnobjectinanotherapplicationdomain_Load(object sender, EventArgs e)
        {

        }
    }
}
