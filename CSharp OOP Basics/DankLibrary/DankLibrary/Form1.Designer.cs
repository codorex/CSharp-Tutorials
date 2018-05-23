namespace DankLibrary
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_addToStock = new System.Windows.Forms.Button();
            this.btn_getBookTotal = new System.Windows.Forms.Button();
            this.btn_getLibraryTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(13, 179);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(103, 23);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_addToStock
            // 
            this.btn_addToStock.Location = new System.Drawing.Point(13, 208);
            this.btn_addToStock.Name = "btn_addToStock";
            this.btn_addToStock.Size = new System.Drawing.Size(103, 23);
            this.btn_addToStock.TabIndex = 2;
            this.btn_addToStock.Text = "Add to Stock";
            this.btn_addToStock.UseVisualStyleBackColor = true;
            // 
            // btn_getBookTotal
            // 
            this.btn_getBookTotal.Location = new System.Drawing.Point(12, 237);
            this.btn_getBookTotal.Name = "btn_getBookTotal";
            this.btn_getBookTotal.Size = new System.Drawing.Size(103, 23);
            this.btn_getBookTotal.TabIndex = 3;
            this.btn_getBookTotal.Text = "Book Total";
            this.btn_getBookTotal.UseVisualStyleBackColor = true;
            // 
            // btn_getLibraryTotal
            // 
            this.btn_getLibraryTotal.Location = new System.Drawing.Point(13, 266);
            this.btn_getLibraryTotal.Name = "btn_getLibraryTotal";
            this.btn_getLibraryTotal.Size = new System.Drawing.Size(103, 23);
            this.btn_getLibraryTotal.TabIndex = 4;
            this.btn_getLibraryTotal.Text = "Library Total";
            this.btn_getLibraryTotal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 349);
            this.Controls.Add(this.btn_getLibraryTotal);
            this.Controls.Add(this.btn_getBookTotal);
            this.Controls.Add(this.btn_addToStock);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_addToStock;
        private System.Windows.Forms.Button btn_getBookTotal;
        private System.Windows.Forms.Button btn_getLibraryTotal;
    }
}

