using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0380__FileStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ReadeveryothervalueusingFileSeek.htm
    public partial  class frmReadeveryothervalueusingFileSeek:Form
    {
        public frmReadeveryothervalueusingFileSeek()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadeveryothervalueusingFileSeek
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadeveryothervalueusingFileSeek";
            this.Text = "frmReadeveryothervalueusingFileSeek";
            this.Load += new System.EventHandler(this.frmReadeveryothervalueusingFileSeek_Load);
            this.ResumeLayout(false);

        }

        private void frmReadeveryothervalueusingFileSeek_Load(object sender, EventArgs e)
        {

        }
    }
}
