using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Addaconstructorwiththreeparameters.htm
    public partial  class frmAddaconstructorwiththreeparameters:Form
    {
        public frmAddaconstructorwiththreeparameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaconstructorwiththreeparameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaconstructorwiththreeparameters";
            this.Text = "frmAddaconstructorwiththreeparameters";
            this.Load += new System.EventHandler(this.frmAddaconstructorwiththreeparameters_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaconstructorwiththreeparameters_Load(object sender, EventArgs e)
        {

        }
    }
}
