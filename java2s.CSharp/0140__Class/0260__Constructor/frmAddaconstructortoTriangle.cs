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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/AddaconstructortoTriangle.htm
    public partial  class frmAddaconstructortoTriangle:Form
    {
        public frmAddaconstructortoTriangle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaconstructortoTriangle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaconstructortoTriangle";
            this.Text = "frmAddaconstructortoTriangle";
            this.Load += new System.EventHandler(this.frmAddaconstructortoTriangle_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaconstructortoTriangle_Load(object sender, EventArgs e)
        {

        }
    }
}
