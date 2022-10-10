using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0780__Extension_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ObjectInitializer.htm
    public partial  class frmObjectInitializer:Form
    {
        public frmObjectInitializer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObjectInitializer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObjectInitializer";
            this.Text = "frmObjectInitializer";
            this.Load += new System.EventHandler(this.frmObjectInitializer_Load);
            this.ResumeLayout(false);

        }

        private void frmObjectInitializer_Load(object sender, EventArgs e)
        {

        }
    }
}
