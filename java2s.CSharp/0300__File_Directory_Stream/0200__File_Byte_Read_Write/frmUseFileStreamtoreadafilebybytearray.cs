using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0200__File_Byte_Read_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseFileStreamtoreadafilebybytearray.htm
    public partial  class frmUseFileStreamtoreadafilebybytearray:Form
    {
        public frmUseFileStreamtoreadafilebybytearray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFileStreamtoreadafilebybytearray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFileStreamtoreadafilebybytearray";
            this.Text = "frmUseFileStreamtoreadafilebybytearray";
            this.Load += new System.EventHandler(this.frmUseFileStreamtoreadafilebybytearray_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFileStreamtoreadafilebybytearray_Load(object sender, EventArgs e)
        {

        }
    }
}
