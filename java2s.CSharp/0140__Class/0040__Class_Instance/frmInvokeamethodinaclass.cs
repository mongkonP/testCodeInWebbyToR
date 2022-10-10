using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0040__Class_Instance
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Invokeamethodinaclass.htm
    public partial  class frmInvokeamethodinaclass:Form
    {
        public frmInvokeamethodinaclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokeamethodinaclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokeamethodinaclass";
            this.Text = "frmInvokeamethodinaclass";
            this.Load += new System.EventHandler(this.frmInvokeamethodinaclass_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokeamethodinaclass_Load(object sender, EventArgs e)
        {

        }
    }
}
