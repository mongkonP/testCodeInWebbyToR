using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0040__Read
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/GetProperties.htm
    public partial  class frmGetProperties:Form
    {
        public frmGetProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetProperties";
            this.Text = "frmGetProperties";
            this.Load += new System.EventHandler(this.frmGetProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmGetProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
