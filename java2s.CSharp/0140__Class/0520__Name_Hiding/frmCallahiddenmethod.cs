using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0520__Name_Hiding
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Callahiddenmethod.htm
    public partial  class frmCallahiddenmethod:Form
    {
        public frmCallahiddenmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallahiddenmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallahiddenmethod";
            this.Text = "frmCallahiddenmethod";
            this.Load += new System.EventHandler(this.frmCallahiddenmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmCallahiddenmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
