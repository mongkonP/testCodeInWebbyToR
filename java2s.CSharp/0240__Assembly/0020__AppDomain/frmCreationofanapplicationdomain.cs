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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Creationofanapplicationdomain.htm
    public partial  class frmCreationofanapplicationdomain:Form
    {
        public frmCreationofanapplicationdomain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreationofanapplicationdomain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreationofanapplicationdomain";
            this.Text = "frmCreationofanapplicationdomain";
            this.Load += new System.EventHandler(this.frmCreationofanapplicationdomain_Load);
            this.ResumeLayout(false);

        }

        private void frmCreationofanapplicationdomain_Load(object sender, EventArgs e)
        {

        }
    }
}
