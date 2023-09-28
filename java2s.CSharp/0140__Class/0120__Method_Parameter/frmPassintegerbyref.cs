using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passintegerbyref.htm
    public partial  class frmPassintegerbyref:Form
    {
        public frmPassintegerbyref()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassintegerbyref
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassintegerbyref";
            this.Text = "frmPassintegerbyref";
            this.Load += new System.EventHandler(this.frmPassintegerbyref_Load);
            this.ResumeLayout(false);

        }

        private void frmPassintegerbyref_Load(object sender, EventArgs e)
        {

        }
    }
}
