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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Addconstructorstobaseclass.htm
    public partial  class frmAddconstructorstobaseclass:Form
    {
        public frmAddconstructorstobaseclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddconstructorstobaseclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddconstructorstobaseclass";
            this.Text = "frmAddconstructorstobaseclass";
            this.Load += new System.EventHandler(this.frmAddconstructorstobaseclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAddconstructorstobaseclass_Load(object sender, EventArgs e)
        {

        }
    }
}
