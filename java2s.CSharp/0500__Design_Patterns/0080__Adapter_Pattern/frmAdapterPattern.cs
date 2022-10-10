using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0080__Adapter_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/AdapterPattern.htm
    public partial  class frmAdapterPattern:Form
    {
        public frmAdapterPattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAdapterPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAdapterPattern";
            this.Text = "frmAdapterPattern";
            this.Load += new System.EventHandler(this.frmAdapterPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmAdapterPattern_Load(object sender, EventArgs e)
        {

        }
    }
}
