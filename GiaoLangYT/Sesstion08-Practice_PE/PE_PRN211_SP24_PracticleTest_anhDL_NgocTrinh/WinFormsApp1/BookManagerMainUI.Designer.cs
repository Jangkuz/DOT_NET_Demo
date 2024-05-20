namespace WinFormsApp1
{
    partial class formBookManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grbSearch = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblDescription = new Label();
            lblName = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblTradeMark = new Label();
            grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Yellow;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Manager";
            lblTitle.Click += label1_Click;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(txtDescription);
            grbSearch.Controls.Add(txtName);
            grbSearch.Controls.Add(lblDescription);
            grbSearch.Controls.Add(lblName);
            grbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbSearch.ForeColor = Color.Yellow;
            grbSearch.Location = new Point(26, 98);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(1021, 99);
            grbSearch.TabIndex = 2;
            grbSearch.TabStop = false;
            grbSearch.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Yellow;
            btnSearch.Location = new Point(836, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 47);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(546, 44);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(157, 33);
            txtDescription.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 33);
            txtName.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(426, 47);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(48, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(868, 234);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(168, 47);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(868, 309);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 47);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(868, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 47);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(868, 460);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 47);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(26, 224);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowTemplate.Height = 25;
            dgvBookList.Size = new Size(822, 283);
            dgvBookList.TabIndex = 9;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblTradeMark
            // 
            lblTradeMark.AutoSize = true;
            lblTradeMark.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTradeMark.ForeColor = Color.Yellow;
            lblTradeMark.Location = new Point(38, 523);
            lblTradeMark.Name = "lblTradeMark";
            lblTradeMark.Size = new Size(83, 21);
            lblTradeMark.TabIndex = 10;
            lblTradeMark.Text = "®anh.dl™";
            // 
            // formBookManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1059, 554);
            Controls.Add(lblTradeMark);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(grbSearch);
            Controls.Add(lblTitle);
            Name = "formBookManager";
            Text = "Book manager";
            Load += formBookManager_Load;
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbSearch;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblDescription;
        private Label lblName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Button btnSearch;
        private Label lblTradeMark;
    }
}
