using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1700__Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Repetitioncount.htm
    public partial  class frmRepetitioncount:Form
    {
        public frmRepetitioncount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRepetitioncount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRepetitioncount";
            this.Text = "frmRepetitioncount";
            this.Load += new System.EventHandler(this.frmRepetitioncount_Load);
            this.ResumeLayout(false);

        }

        private void frmRepetitioncount_Load(object sender, EventArgs e)
        {

        }
    }
}
