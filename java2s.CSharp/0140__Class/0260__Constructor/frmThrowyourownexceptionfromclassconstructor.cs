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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Throwyourownexceptionfromclassconstructor.htm
    public partial  class frmThrowyourownexceptionfromclassconstructor:Form
    {
        public frmThrowyourownexceptionfromclassconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowyourownexceptionfromclassconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowyourownexceptionfromclassconstructor";
            this.Text = "frmThrowyourownexceptionfromclassconstructor";
            this.Load += new System.EventHandler(this.frmThrowyourownexceptionfromclassconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowyourownexceptionfromclassconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
