using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0280__destructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UsedestructorandimplementIDisposable.htm
    public partial  class frmUsedestructorandimplementIDisposable:Form
    {
        public frmUsedestructorandimplementIDisposable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsedestructorandimplementIDisposable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsedestructorandimplementIDisposable";
            this.Text = "frmUsedestructorandimplementIDisposable";
            this.Load += new System.EventHandler(this.frmUsedestructorandimplementIDisposable_Load);
            this.ResumeLayout(false);

        }

        private void frmUsedestructorandimplementIDisposable_Load(object sender, EventArgs e)
        {

        }
    }
}
