using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0540__BinaryWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Writeandreadbackbinarydata.htm
    public partial  class frmWriteandreadbackbinarydata:Form
    {
        public frmWriteandreadbackbinarydata()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriteandreadbackbinarydata
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriteandreadbackbinarydata";
            this.Text = "frmWriteandreadbackbinarydata";
            this.Load += new System.EventHandler(this.frmWriteandreadbackbinarydata_Load);
            this.ResumeLayout(false);

        }

        private void frmWriteandreadbackbinarydata_Load(object sender, EventArgs e)
        {

        }
    }
}
