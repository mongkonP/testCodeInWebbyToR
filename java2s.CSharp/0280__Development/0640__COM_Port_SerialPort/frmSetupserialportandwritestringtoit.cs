using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0640__COM_Port_SerialPort
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Setupserialportandwritestringtoit.htm
    public partial  class frmSetupserialportandwritestringtoit:Form
    {
        public frmSetupserialportandwritestringtoit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetupserialportandwritestringtoit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetupserialportandwritestringtoit";
            this.Text = "frmSetupserialportandwritestringtoit";
            this.Load += new System.EventHandler(this.frmSetupserialportandwritestringtoit_Load);
            this.ResumeLayout(false);

        }

        private void frmSetupserialportandwritestringtoit_Load(object sender, EventArgs e)
        {

        }
    }
}
