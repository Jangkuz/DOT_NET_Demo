using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager_anhDL
{
    public partial class BookDetailForm : Form
    {
        // vì DetailForm cx là 1 class, nên nó có prop như bt, Hơn bt là nó là class có thể render (bố/cha class form của sdk lo phần render - mqh thừa.

        public Book? SelectedBook { get; set; } = null;
        //mặc định form này mở lên, ko hco book nào cả
        //nếu muốn có book thì phải
        //.SelectedBook = cuốn muốn gán vô.

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MÚN EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //2. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ USER NHẬP INFO - KO CẦN LÀM GÌ THÊM.

            BookCategoryServices cat = new BookCategoryServices();
            //đổ full data vào cbo
            cboBookCategoryId.DataSource = cat.GetAllCategories();
            //chọn cột để hiển thị
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what you see is not what you get
            //chọn self hellp dễ cho user -> code map sang value 5 của cột BookCategoryId, dùng làm FK đẩy vào table BOOK
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi dieu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1.
            cboBookCategoryId.SelectedValue = 1;    //default với mình.


            //Check hàng, có phải là edit hay ko?
            //check biến selectedbook coi có được set khác null hay ko?
            //nếu có sách thì fill vào các ô.
            if (SelectedBook != null)
            {//start SelectedBook exist
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                txtAuthor.Text = SelectedBook.Author;
                txtPrice.Text = SelectedBook.Price.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();

                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;
                //tùy sách có cate gì thì jump đến số đó.
            }//end SelectedBook exist

        }
    }
}
