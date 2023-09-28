using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0440__Base_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Addmoreconstructorstobaseclass.htm
    public partial  class frmAddmoreconstructorstobaseclass:Form
    {
        public frmAddmoreconstructorstobaseclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddmoreconstructorstobaseclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddmoreconstructorstobaseclass";
            this.Text = "frmAddmoreconstructorstobaseclass";
            this.Load += new System.EventHandler(this.frmAddmoreconstructorstobaseclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAddmoreconstructorstobaseclass_Load(object sender, EventArgs e)
        {

        }
    }
}
