using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InvokeIndexedPropertyDemo.htm
    public partial  class frmInvokeIndexedPropertyDemo:Form
    {
        public frmInvokeIndexedPropertyDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokeIndexedPropertyDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokeIndexedPropertyDemo";
            this.Text = "frmInvokeIndexedPropertyDemo";
            this.Load += new System.EventHandler(this.frmInvokeIndexedPropertyDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokeIndexedPropertyDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
