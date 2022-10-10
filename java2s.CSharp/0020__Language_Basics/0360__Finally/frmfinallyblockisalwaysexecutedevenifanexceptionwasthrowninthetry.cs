using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0360__Finally
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/finallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry.htm
    public partial  class frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry:Form
    {
        public frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry";
            this.Text = "frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry";
            this.Load += new System.EventHandler(this.frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry_Load);
            this.ResumeLayout(false);

        }

        private void frmfinallyblockisalwaysexecutedevenifanexceptionwasthrowninthetry_Load(object sender, EventArgs e)
        {

        }
    }
}
