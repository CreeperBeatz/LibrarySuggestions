namespace LibraryWinforms
{
    partial class MainMenu
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
            this.AddBookButton = new System.Windows.Forms.Button();
            this.SearchAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(260, 156);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(283, 73);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Add book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // SearchAuthorButton
            // 
            this.SearchAuthorButton.Location = new System.Drawing.Point(260, 268);
            this.SearchAuthorButton.Name = "SearchAuthorButton";
            this.SearchAuthorButton.Size = new System.Drawing.Size(283, 75);
            this.SearchAuthorButton.TabIndex = 2;
            this.SearchAuthorButton.Text = "Search Author";
            this.SearchAuthorButton.UseVisualStyleBackColor = true;
            this.SearchAuthorButton.Click += new System.EventHandler(this.SearchAuthorButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchAuthorButton);
            this.Controls.Add(this.AddBookButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button AddBookButton;
        private Button SearchAuthorButton;
    }
}