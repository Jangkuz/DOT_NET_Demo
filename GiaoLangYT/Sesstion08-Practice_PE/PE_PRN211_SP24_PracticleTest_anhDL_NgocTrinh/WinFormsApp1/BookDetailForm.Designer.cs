namespace BookManager_anhDL
{
    partial class BookDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookDetailTitle = new Label();
            grpBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            lblName = new Label();
            lblQuantity = new Label();
            lblID = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            grpBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookDetailTitle
            // 
            lblBookDetailTitle.AutoSize = true;
            lblBookDetailTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDetailTitle.Location = new Point(12, 9);
            lblBookDetailTitle.Name = "lblBookDetailTitle";
            lblBookDetailTitle.Size = new Size(384, 50);
            lblBookDetailTitle.TabIndex = 1;
            lblBookDetailTitle.Text = "Add | Update a Book";
            // 
            // grpBookInfo
            // 
            grpBookInfo.BackColor = Color.Red;
            grpBookInfo.Controls.Add(cboBookCategoryId);
            grpBookInfo.Controls.Add(dtpPublicationDate);
            grpBookInfo.Controls.Add(txtDescription);
            grpBookInfo.Controls.Add(txtPrice);
            grpBookInfo.Controls.Add(txtQuantity);
            grpBookInfo.Controls.Add(txtAuthor);
            grpBookInfo.Controls.Add(txtBookName);
            grpBookInfo.Controls.Add(txtBookId);
            grpBookInfo.Controls.Add(lblPrice);
            grpBookInfo.Controls.Add(lblCategory);
            grpBookInfo.Controls.Add(lblAuthor);
            grpBookInfo.Controls.Add(lblPublicationDate);
            grpBookInfo.Controls.Add(lblDescription);
            grpBookInfo.Controls.Add(lblName);
            grpBookInfo.Controls.Add(lblQuantity);
            grpBookInfo.Controls.Add(lblID);
            grpBookInfo.FlatStyle = FlatStyle.Flat;
            grpBookInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpBookInfo.ForeColor = Color.Yellow;
            grpBookInfo.Location = new Point(46, 89);
            grpBookInfo.Name = "grpBookInfo";
            grpBookInfo.Size = new Size(641, 445);
            grpBookInfo.TabIndex = 0;
            grpBookInfo.TabStop = false;
            grpBookInfo.Text = "Book's Detail";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(191, 397);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(159, 33);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(191, 250);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(159, 33);
            dtpPublicationDate.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(191, 138);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(417, 106);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(484, 299);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(124, 33);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(191, 299);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(142, 33);
            txtQuantity.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(191, 349);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(417, 33);
            txtAuthor.TabIndex = 6;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(191, 88);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(417, 33);
            txtBookName.TabIndex = 1;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(191, 38);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(142, 33);
            txtBookId.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(422, 302);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(26, 397);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.Location = new Point(26, 352);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(75, 25);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicationDate.Location = new Point(26, 256);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(159, 25);
            lblPublicationDate.TabIndex = 5;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(26, 141);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(26, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(26, 302);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(89, 25);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(26, 41);
            lblID.Name = "lblID";
            lblID.Size = new Size(32, 25);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(702, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(702, 169);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(884, 551);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpBookInfo);
            Controls.Add(lblBookDetailTitle);
            ForeColor = Color.Yellow;
            Name = "BookDetailForm";
            Text = "Add | Update Book";
            Load += BookDetailForm_Load;
            grpBookInfo.ResumeLayout(false);
            grpBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBookDetailTitle;
        private GroupBox grpBookInfo;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPublicationDate;
        private Label lblDescription;
        private Label lblName;
        private Label lblQuantity;
        private Label lblID;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtAuthor;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPublicationDate;
    }
}