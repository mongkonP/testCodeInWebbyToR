using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0600__Binary_Serialization
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/BinaryCustomSerialization.htm
    public partial  class frmBinaryCustomSerialization:Form
    {
        public frmBinaryCustomSerialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBinaryCustomSerialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBinaryCustomSerialization";
            this.Text = "frmBinaryCustomSerialization";
            this.Load += new System.EventHandler(this.frmBinaryCustomSerialization_Load);
            this.ResumeLayout(false);

        }

        private void frmBinaryCustomSerialization_Load(object sender, EventArgs e)
        {

        }
    }
}
