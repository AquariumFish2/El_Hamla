using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class parcode : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public parcode()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);

            // إعدادات الورقة المخصصة بحجم 3.5 سم × 2.5 سم
            int width = (int)(3.5 * 100); // تحويل السنتيمتر إلى بوصة بالـ100
            int height = (int)(2.5 * 100); // تحويل السنتيمتر إلى بوصة بالـ100
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", width, height);

            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.UseAntiAlias = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // إعدادات حجم الطباعة
            float targetWidth = 3.5f * 100 / 2.54f;  // تحويل العرض إلى وحدات البوصة
            float targetHeight = 2.5f * 100 / 2.54f; // تحويل الطول إلى وحدات البوصة

            // تحديد موضع الرسم (أعلى الورقة)
            float startX = (e.PageBounds.Width - targetWidth) / 2;
            float startY = 20;  // ضبط المسافة الرأسية ليكون النص في أعلى الصفحة

            // إعدادات الخطوط للنصوص المختلفة
            Font printFont1 = new Font("Andalus", 8);
            Font printFont = new Font("CCode39", 12);
            Font printFont2 = new Font("Andalus", 8);

            // نصوص التكست بوكس المختلفة
            string textToPrint1 = textBox2.Text;
            string textToPrint2 = barcode.Text;
            string textToPrint3 = name.Text;

            // حساب العرض لكل نص لتوسيطه في المستطيل المحدد
            SizeF textSize1 = e.Graphics.MeasureString(textToPrint1, printFont1);
            SizeF textSize2 = e.Graphics.MeasureString(textToPrint2, printFont);
            SizeF textSize3 = e.Graphics.MeasureString(textToPrint3, printFont2);

            // توسيط النصوص داخل المستطيل المحدد (3.5 سم × 2.5 سم)
            float centerX1 = startX + (targetWidth - textSize1.Width) / 2;
            float centerX2 = startX + (targetWidth - textSize2.Width) / 2;
            float centerX3 = startX + (targetWidth - textSize3.Width) / 2;

            // تحديد المسافة الرأسية بين كل عنصر
            float topMargin = startY;
            e.Graphics.DrawString(textToPrint1, printFont1, Brushes.Black, centerX1, topMargin);
            e.Graphics.DrawString(textToPrint2, printFont, Brushes.Black, centerX2, topMargin + textSize1.Height);
            e.Graphics.DrawString(textToPrint3, printFont2, Brushes.Black, centerX3, topMargin + textSize1.Height + textSize2.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument1;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings = printDialog.PrinterSettings;

                    string input = Microsoft.VisualBasic.Interaction.InputBox("أدخل عدد النسخ المطلوبة:", "عدد النسخ", "1");
                    if (int.TryParse(input, out int copies) && copies > 0)
                    {
                        printDocument1.PrinterSettings.Copies = (short)copies;

                        // عرض معاينة الطباعة
                        printPreviewDialog.ShowDialog();

                        // تنفيذ الطباعة بعد المعاينة إذا لزم الأمر
                        if (MessageBox.Show("هل ترغب في الطباعة الآن؟", "تأكيد الطباعة", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            printDocument1.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى إدخال عدد نسخ صالح.");
                    }
                }
            }
        }

        private void parcode_Load(object sender, EventArgs e)
        {
            textBox2.Text = "قسم _ المركبات";
        }
    }
}
