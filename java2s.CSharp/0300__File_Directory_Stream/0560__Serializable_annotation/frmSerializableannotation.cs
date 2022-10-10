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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Serializableannotation.htm
    public partial  class frmSerializableannotation:Form
    {
        public frmSerializableannotation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSerializableannotation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSerializableannotation";
            this.Text = "frmSerializableannotation";
            this.Load += new System.EventHandler(this.frmSerializableannotation_Load);
            this.ResumeLayout(false);

        }

        private void frmSerializableannotation_Load(object sender, EventArgs e)
        {

        }
    }
}
