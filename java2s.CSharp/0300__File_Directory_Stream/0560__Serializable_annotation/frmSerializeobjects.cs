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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Serializeobjects.htm
    public partial  class frmSerializeobjects:Form
    {
        public frmSerializeobjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializeobjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializeobjects";
            this.Text = "frmSerializeobjects";
            this.Load += new System.EventHandler(this.frmSerializeobjects_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializeobjects_Load(object sender, EventArgs e)
        {

        }
    }
}
