using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0220__Assembly
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/DefineDynamicAssemblymethodandAssemblyResolveevent.htm
    public partial  class frmDefineDynamicAssemblymethodandAssemblyResolveevent:Form
    {
        public frmDefineDynamicAssemblymethodandAssemblyResolveevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineDynamicAssemblymethodandAssemblyResolveevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineDynamicAssemblymethodandAssemblyResolveevent";
            this.Text = "frmDefineDynamicAssemblymethodandAssemblyResolveevent";
            this.Load += new System.EventHandler(this.frmDefineDynamicAssemblymethodandAssemblyResolveevent_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineDynamicAssemblymethodandAssemblyResolveevent_Load(object sender, EventArgs e)
        {

        }
    }
}
