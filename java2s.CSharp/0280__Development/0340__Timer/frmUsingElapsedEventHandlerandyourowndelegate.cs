using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UsingElapsedEventHandlerandyourowndelegate.htm
    public partial  class frmUsingElapsedEventHandlerandyourowndelegate:Form
    {
        public frmUsingElapsedEventHandlerandyourowndelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingElapsedEventHandlerandyourowndelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingElapsedEventHandlerandyourowndelegate";
            this.Text = "frmUsingElapsedEventHandlerandyourowndelegate";
            this.Load += new System.EventHandler(this.frmUsingElapsedEventHandlerandyourowndelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingElapsedEventHandlerandyourowndelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
