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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Classinheritancewithvirtualmethod.htm
    public partial  class frmClassinheritancewithvirtualmethod:Form
    {
        public frmClassinheritancewithvirtualmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClassinheritancewithvirtualmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClassinheritancewithvirtualmethod";
            this.Text = "frmClassinheritancewithvirtualmethod";
            this.Load += new System.EventHandler(this.frmClassinheritancewithvirtualmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmClassinheritancewithvirtualmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
