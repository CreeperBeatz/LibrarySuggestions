using LibraryWPF.ViewModels;

namespace LibraryWinforms
{
    partial class SearchAuthor
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
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.suggestionBoxWrapper1 = new LibraryWinforms.SuggestionBoxUserControl.SuggestionBoxWrapper();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 392);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(251, 46);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Location = new System.Drawing.Point(284, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(493, 427);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // suggestionBoxWrapper1
            // 
            this.suggestionBoxWrapper1.Location = new System.Drawing.Point(12, 12);
            this.suggestionBoxWrapper1.Name = "suggestionBoxWrapper1";
            this.suggestionBoxWrapper1.Size = new System.Drawing.Size(255, 47);
            this.suggestionBoxWrapper1.TabIndex = 3;
            this.suggestionBoxWrapper1.Load += new System.EventHandler(this.suggestionBoxWrapper1_Load);
            // 
            // SearchAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suggestionBoxWrapper1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchButton);
            this.Name = "SearchAuthor";
            this.Text = "SearchAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button searchButton;
        private DataGridView dataGridView;
        private SuggestionBoxUserControl.SuggestionBoxWrapper suggestionBoxWrapper1;
    }
}