using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Theuseofnamespacehierarchies.htm
    public partial  class frmTheuseofnamespacehierarchies:Form
    {
        public frmTheuseofnamespacehierarchies()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheuseofnamespacehierarchies
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheuseofnamespacehierarchies";
            this.Text = "frmTheuseofnamespacehierarchies";
            this.Load += new System.EventHandler(this.frmTheuseofnamespacehierarchies_Load);
            this.ResumeLayout(false);

        }

        private void frmTheuseofnamespacehierarchies_Load(object sender, EventArgs e)
        {

        }
    }
}
