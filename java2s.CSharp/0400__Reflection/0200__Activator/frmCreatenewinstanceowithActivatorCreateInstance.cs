using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0200__Activator
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/CreatenewinstanceowithActivatorCreateInstance.htm
    public partial  class frmCreatenewinstanceowithActivatorCreateInstance:Form
    {
        public frmCreatenewinstanceowithActivatorCreateInstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatenewinstanceowithActivatorCreateInstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatenewinstanceowithActivatorCreateInstance";
            this.Text = "frmCreatenewinstanceowithActivatorCreateInstance";
            this.Load += new System.EventHandler(this.frmCreatenewinstanceowithActivatorCreateInstance_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatenewinstanceowithActivatorCreateInstance_Load(object sender, EventArgs e)
        {

        }
    }
}
