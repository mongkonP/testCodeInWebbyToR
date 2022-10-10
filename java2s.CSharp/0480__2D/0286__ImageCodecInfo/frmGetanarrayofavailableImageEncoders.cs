using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0286__ImageCodecInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GetanarrayofavailableImageEncoders.htm
    public partial  class frmGetanarrayofavailableImageEncoders:Form
    {
        private RichTextBox richTextBox1;

        public frmGetanarrayofavailableImageEncoders()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmGetanarrayofavailableImageEncoders
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmGetanarrayofavailableImageEncoders";
            this.Text = "frmGetanarrayofavailableImageEncoders";
            this.Load += new System.EventHandler(this.frmGetanarrayofavailableImageEncoders_Load);
            this.ResumeLayout(false);

        }

        private void frmGetanarrayofavailableImageEncoders_Load(object sender, EventArgs e)
        {
            ImageCodecInfo[] availableCodecs;
            availableCodecs = ImageCodecInfo.GetImageEncoders();
            int numCodecs = availableCodecs.Length;

            for (int i = 0; i < numCodecs; i++)
            {
                richTextBox1 .WriteLine("Codec Name = " + availableCodecs[i].CodecName);
                richTextBox1.WriteLine("Class ID = " + availableCodecs[i].Clsid.ToString());
                richTextBox1.WriteLine("Filename Extension = " +
                  availableCodecs[i].FilenameExtension);
                richTextBox1.WriteLine("Flags = " +
                  availableCodecs[i].Flags.ToString());
                richTextBox1.WriteLine("Format Description = " +
                  availableCodecs[i].FormatDescription);
                richTextBox1.WriteLine("Format ID = " +
                  availableCodecs[i].FormatID.ToString());
                richTextBox1.WriteLine("MimeType = " + availableCodecs[i].MimeType);
                richTextBox1.WriteLine("Version = " +
                  availableCodecs[i].Version.ToString());
                richTextBox1.WriteLine();
            }
        }
    }
}
