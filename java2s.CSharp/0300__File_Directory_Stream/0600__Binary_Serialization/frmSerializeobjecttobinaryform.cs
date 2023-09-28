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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Serializeobjecttobinaryform.htm
    public partial  class frmSerializeobjecttobinaryform:Form
    {
        public frmSerializeobjecttobinaryform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializeobjecttobinaryform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializeobjecttobinaryform";
            this.Text = "frmSerializeobjecttobinaryform";
            this.Load += new System.EventHandler(this.frmSerializeobjecttobinaryform_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializeobjecttobinaryform_Load(object sender, EventArgs e)
        {

        }
    }
}
