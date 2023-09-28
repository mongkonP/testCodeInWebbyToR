using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1680__Binder
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/extendsBindertocreateyourownbinder.htm
    public partial  class frmextendsBindertocreateyourownbinder:Form
    {
        public frmextendsBindertocreateyourownbinder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsBindertocreateyourownbinder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsBindertocreateyourownbinder";
            this.Text = "frmextendsBindertocreateyourownbinder";
            this.Load += new System.EventHandler(this.frmextendsBindertocreateyourownbinder_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsBindertocreateyourownbinder_Load(object sender, EventArgs e)
        {

        }
    }
}
