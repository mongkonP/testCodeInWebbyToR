using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usevirtualmethodsandpolymorphism.htm
    public partial  class frmUsevirtualmethodsandpolymorphism:Form
    {
        public frmUsevirtualmethodsandpolymorphism()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsevirtualmethodsandpolymorphism
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsevirtualmethodsandpolymorphism";
            this.Text = "frmUsevirtualmethodsandpolymorphism";
            this.Load += new System.EventHandler(this.frmUsevirtualmethodsandpolymorphism_Load);
            this.ResumeLayout(false);

        }

        private void frmUsevirtualmethodsandpolymorphism_Load(object sender, EventArgs e)
        {

        }
    }
}
