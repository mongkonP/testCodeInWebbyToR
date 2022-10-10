using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0420__Derived_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Illustratesmemberaccessibilityinsubclass.htm
    public partial  class frmIllustratesmemberaccessibilityinsubclass:Form
    {
        public frmIllustratesmemberaccessibilityinsubclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustratesmemberaccessibilityinsubclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustratesmemberaccessibilityinsubclass";
            this.Text = "frmIllustratesmemberaccessibilityinsubclass";
            this.Load += new System.EventHandler(this.frmIllustratesmemberaccessibilityinsubclass_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustratesmemberaccessibilityinsubclass_Load(object sender, EventArgs e)
        {

        }
    }
}
