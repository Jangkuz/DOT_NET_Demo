using Services;
using System.Windows.Forms.VisualStyles;

namespace Zodiac
{
    //Class form chính là class kế thừa (inherit/inheritance) cái class gốc mà Windos cung cấp để render ra cửa sổ tương tác
    //Form là class Cha, Parent, class gốc có khả năng render 1 HCN ~ web page để cung cấp mặt sàn tương tác với user
    //ta lập trình app GUI, app Desktop, tức là cái app chạy trên enn26 Desktop, có icon biểu tượng trên thanh Taskbar, chính là tạo ra 1 class kế thừa class Form
    //          Con extends Cha
    //          con kế thừa Cha
    //          Dog     Pet
    //          chữ kết thừa trong Java là Extends
    //          chữ kết thừa trong C# là:  
    public partial class ZodiacManager : Form
    {
        //partial: chia 1 class ra làm nhiều nơi viết
        //khi biên dịch thì merge all partial lại với nhau

        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZodiacManager_Load(object sender, EventArgs e)
        {

        }

        private void btnShowImage1_ClicK(object sender, EventArgs e)
        {
            //đưa ảnh vào RAM
            Image img = Image.FromFile(@"signs\HotGirl.jpg");
            //Image img = Image.FromFile("signs\\HotGirl.jpg");
            //đường file cho window: \
            //đường file cho linux: /

            //Show ảnh
            // img src=""
            picImage.Image = img;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);   //Text {get;}
            int month = int.Parse(txtMonth.Text);

            string zodiacEnglish = CalculateZodiac.calculateZodiacEnglish(day, month);
            string zodiacVietnamese = CalculateZodiac.getZodiacVietnamese(zodiacEnglish);

            //string zodiacImage = @"signs\" + zodiacEnglish + ".jpg";
            string zodiacImage = "signs\\" + zodiacEnglish + ".jpg";
            //load anh3 va2 cap65 nhat65 status

            Image img = Image.FromFile(zodiacImage);
            picImage.Image = img;
            lblZodiacSign.Text = $"Your zodiac sign is: {zodiacEnglish} - {zodiacVietnamese}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //xác nhận muốn thoát app hay ko
            DialogResult answer = MessageBox.Show("Do you really want to exit??", "Quit!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //MessageBoxButtons trả về giá trị lựa chọn của user
            //giá trị này thuộc data type -> DialogResult.
            if (answer == DialogResult.Yes)
            {
                Application.Exit();

            }

        }
    }
}
