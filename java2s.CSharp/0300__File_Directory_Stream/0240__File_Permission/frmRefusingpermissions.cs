using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0240__File_Permission
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Refusingpermissions.htm
    public partial  class frmRefusingpermissions:Form
    {
        public frmRefusingpermissions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRefusingpermissions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRefusingpermissions";
            this.Text = "frmRefusingpermissions";
            this.Load += new System.EventHandler(this.frmRefusingpermissions_Load);
            this.ResumeLayout(false);

        }

        private void frmRefusingpermissions_Load(object sender, EventArgs e)
        {

        }
    }
}
