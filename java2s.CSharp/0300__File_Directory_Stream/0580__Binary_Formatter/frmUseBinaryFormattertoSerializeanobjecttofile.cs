using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0580__Binary_Formatter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseBinaryFormattertoSerializeanobjecttofile.htm
    public partial  class frmUseBinaryFormattertoSerializeanobjecttofile:Form
    {
        public frmUseBinaryFormattertoSerializeanobjecttofile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseBinaryFormattertoSerializeanobjecttofile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseBinaryFormattertoSerializeanobjecttofile";
            this.Text = "frmUseBinaryFormattertoSerializeanobjecttofile";
            this.Load += new System.EventHandler(this.frmUseBinaryFormattertoSerializeanobjecttofile_Load);
            this.ResumeLayout(false);

        }

        private void frmUseBinaryFormattertoSerializeanobjecttofile_Load(object sender, EventArgs e)
        {

        }
    }
}
