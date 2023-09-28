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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/SameclassnameunderdifferentNamespaces.htm
    public partial  class frmSameclassnameunderdifferentNamespaces:Form
    {
        public frmSameclassnameunderdifferentNamespaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSameclassnameunderdifferentNamespaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSameclassnameunderdifferentNamespaces";
            this.Text = "frmSameclassnameunderdifferentNamespaces";
            this.Load += new System.EventHandler(this.frmSameclassnameunderdifferentNamespaces_Load);
            this.ResumeLayout(false);

        }

        private void frmSameclassnameunderdifferentNamespaces_Load(object sender, EventArgs e)
        {

        }
    }
}
