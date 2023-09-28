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
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/ListObjects.htm
    public partial  class frmListObjects:Form
    {
        public frmListObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListObjects";
            this.Text = "frmListObjects";
            this.Load += new System.EventHandler(this.frmListObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmListObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
