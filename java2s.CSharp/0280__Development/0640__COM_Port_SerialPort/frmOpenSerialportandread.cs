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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/OpenSerialportandread.htm
    public partial  class frmOpenSerialportandread:Form
    {
        public frmOpenSerialportandread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenSerialportandread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenSerialportandread";
            this.Text = "frmOpenSerialportandread";
            this.Load += new System.EventHandler(this.frmOpenSerialportandread_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenSerialportandread_Load(object sender, EventArgs e)
        {

        }
    }
}
