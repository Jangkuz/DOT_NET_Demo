using BookManager_anhDL;
using Repositories.Entities;
using Services;

namespace WinFormsApp1
{
    public partial class formBookManager : Form
    {
        public formBookManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formBookManager_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            BookService service = new BookService();
            dgvBookList.DataSource = null; //xoa trắng grid
            dgvBookList.DataSource = service.GetAllBooks();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản cht61 là class BookDetailForm, khác truyền thống là nó có phần render bề mặt!!
            //Nó 1 class nên nó sẽ có _field, prop, method như bt
            //Khai báo biến, new như bt
            //Thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em
            //f.Show(); //nguy hiểm, new object tùm lùm -> full RAM -> crash.

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột
            //lấy dòng đầu tiên được chọn nếu người ta chọn nhiều dòng.
            if(dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên được chọn là bốc nó ra, đầy sang màn hình detail
                Book selected = (Book) dgvBookList.SelectedRows[0].DataBoundItem;
                //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()

                //đầy sagn From Detail
                //Khai biến, new, gán, prop, show dialog
                //thằng form detail: mở lên, check selected khác null hem? khác null thì mode EDIT, SHOW DATA ĐƯỢC GỬI SANG
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = selected;
                f.ShowDialog();

            }
        }
    }
}
