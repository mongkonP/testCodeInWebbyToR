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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Theuseoftwonamespaces.htm
    public partial  class frmTheuseoftwonamespaces:Form
    {
        public frmTheuseoftwonamespaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheuseoftwonamespaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheuseoftwonamespaces";
            this.Text = "frmTheuseoftwonamespaces";
            this.Load += new System.EventHandler(this.frmTheuseoftwonamespaces_Load);
            this.ResumeLayout(false);

        }

        private void frmTheuseoftwonamespaces_Load(object sender, EventArgs e)
        {

        }
    }
}
