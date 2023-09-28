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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Addconstructortoclass.htm
    public partial  class frmAddconstructortoclass:Form
    {
        public frmAddconstructortoclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddconstructortoclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddconstructortoclass";
            this.Text = "frmAddconstructortoclass";
            this.Load += new System.EventHandler(this.frmAddconstructortoclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAddconstructortoclass_Load(object sender, EventArgs e)
        {

        }
    }
}
