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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/SpecifyNonSerializedfields.htm
    public partial  class frmSpecifyNonSerializedfields:Form
    {
        public frmSpecifyNonSerializedfields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSpecifyNonSerializedfields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSpecifyNonSerializedfields";
            this.Text = "frmSpecifyNonSerializedfields";
            this.Load += new System.EventHandler(this.frmSpecifyNonSerializedfields_Load);
            this.ResumeLayout(false);

        }

        private void frmSpecifyNonSerializedfields_Load(object sender, EventArgs e)
        {

        }
    }
}
