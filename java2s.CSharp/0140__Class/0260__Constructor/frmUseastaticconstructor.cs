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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useastaticconstructor.htm
    public partial  class frmUseastaticconstructor:Form
    {
        public frmUseastaticconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseastaticconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseastaticconstructor";
            this.Text = "frmUseastaticconstructor";
            this.Load += new System.EventHandler(this.frmUseastaticconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmUseastaticconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
