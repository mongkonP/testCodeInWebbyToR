using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0140__Search
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/Searchthedirectories.htm
    public partial  class frmSearchthedirectories:Form
    {
        public frmSearchthedirectories()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSearchthedirectories
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSearchthedirectories";
            this.Text = "frmSearchthedirectories";
            this.Load += new System.EventHandler(this.frmSearchthedirectories_Load);
            this.ResumeLayout(false);

        }

        private void frmSearchthedirectories_Load(object sender, EventArgs e)
        {

        }
    }
}
