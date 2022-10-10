using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0060__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Structconstructorwithparameters.htm
    public partial  class frmStructconstructorwithparameters:Form
    {
        public frmStructconstructorwithparameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStructconstructorwithparameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStructconstructorwithparameters";
            this.Text = "frmStructconstructorwithparameters";
            this.Load += new System.EventHandler(this.frmStructconstructorwithparameters_Load);
            this.ResumeLayout(false);

        }

        private void frmStructconstructorwithparameters_Load(object sender, EventArgs e)
        {

        }
    }
}
