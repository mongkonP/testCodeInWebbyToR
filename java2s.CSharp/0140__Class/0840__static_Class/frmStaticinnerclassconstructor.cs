using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0840__static_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Staticinnerclassconstructor.htm
    public partial  class frmStaticinnerclassconstructor:Form
    {
        public frmStaticinnerclassconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticinnerclassconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticinnerclassconstructor";
            this.Text = "frmStaticinnerclassconstructor";
            this.Load += new System.EventHandler(this.frmStaticinnerclassconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticinnerclassconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
