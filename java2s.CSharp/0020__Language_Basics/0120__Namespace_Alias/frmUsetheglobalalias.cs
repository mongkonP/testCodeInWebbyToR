using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0120__Namespace_Alias
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Usetheglobalalias.htm
    public partial  class frmUsetheglobalalias:Form
    {
        public frmUsetheglobalalias()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheglobalalias
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheglobalalias";
            this.Text = "frmUsetheglobalalias";
            this.Load += new System.EventHandler(this.frmUsetheglobalalias_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheglobalalias_Load(object sender, EventArgs e)
        {

        }
    }
}
