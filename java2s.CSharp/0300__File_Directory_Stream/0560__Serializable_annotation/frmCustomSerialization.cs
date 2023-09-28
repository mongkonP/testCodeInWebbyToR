using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0560__Serializable_annotation
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CustomSerialization.htm
    public partial  class frmCustomSerialization:Form
    {
        public frmCustomSerialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomSerialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomSerialization";
            this.Text = "frmCustomSerialization";
            this.Load += new System.EventHandler(this.frmCustomSerialization_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomSerialization_Load(object sender, EventArgs e)
        {

        }
    }
}
