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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Whenavirtualmethodisnotoverriddenthebaseclassmethodisused.htm
    public partial  class frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused:Form
    {
        public frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused";
            this.Text = "frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused";
            this.Load += new System.EventHandler(this.frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused_Load);
            this.ResumeLayout(false);

        }

        private void frmWhenavirtualmethodisnotoverriddenthebaseclassmethodisused_Load(object sender, EventArgs e)
        {

        }
    }
}
