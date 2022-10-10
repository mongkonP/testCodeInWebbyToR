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
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/GetPropertyCollection.htm
    public partial  class frmGetPropertyCollection:Form
    {
        public frmGetPropertyCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetPropertyCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetPropertyCollection";
            this.Text = "frmGetPropertyCollection";
            this.Load += new System.EventHandler(this.frmGetPropertyCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmGetPropertyCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
