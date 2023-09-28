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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseFileStreamtowriteafilebybytearray.htm
    public partial  class frmUseFileStreamtowriteafilebybytearray:Form
    {
        public frmUseFileStreamtowriteafilebybytearray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFileStreamtowriteafilebybytearray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFileStreamtowriteafilebybytearray";
            this.Text = "frmUseFileStreamtowriteafilebybytearray";
            this.Load += new System.EventHandler(this.frmUseFileStreamtowriteafilebybytearray_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFileStreamtowriteafilebybytearray_Load(object sender, EventArgs e)
        {

        }
    }
}
