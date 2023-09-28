using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0100__Form_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormwithoutMinimizeBoxandMaximizedBox.htm
    public partial  class frmFormwithoutMinimizeBoxandMaximizedBox:Form
    {
        public frmFormwithoutMinimizeBoxandMaximizedBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormwithoutMinimizeBoxandMaximizedBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormwithoutMinimizeBoxandMaximizedBox";
            this.Text = "frmFormwithoutMinimizeBoxandMaximizedBox";
            this.Load += new System.EventHandler(this.frmFormwithoutMinimizeBoxandMaximizedBox_Load);
            this.ResumeLayout(false);

        }

        private void frmFormwithoutMinimizeBoxandMaximizedBox_Load(object sender, EventArgs e)
        {

        }
    }
}
