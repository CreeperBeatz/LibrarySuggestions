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
            this.suggestionBoxWrapper2 = new LibraryWinforms.SuggestionBoxUserControl.SuggestionBoxWrapper();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(10, 294);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(220, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Location = new System.Drawing.Point(248, 8);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(431, 320);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // suggestionBoxWrapper1
            // 
            this.suggestionBoxWrapper1.Location = new System.Drawing.Point(10, 9);
            this.suggestionBoxWrapper1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suggestionBoxWrapper1.Name = "suggestionBoxWrapper1";
            this.suggestionBoxWrapper1.Size = new System.Drawing.Size(223, 35);
            this.suggestionBoxWrapper1.TabIndex = 3;
            this.suggestionBoxWrapper1.Load += new System.EventHandler(this.suggestionBoxWrapper1_Load);
            // 
            // suggestionBoxWrapper2
            // 
            this.suggestionBoxWrapper2.Location = new System.Drawing.Point(487, 0);
            this.suggestionBoxWrapper2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suggestionBoxWrapper2.Name = "suggestionBoxWrapper2";
            this.suggestionBoxWrapper2.Size = new System.Drawing.Size(8, 8);
            this.suggestionBoxWrapper2.TabIndex = 4;
            // 
            // SearchAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.suggestionBoxWrapper2);
            this.Controls.Add(this.suggestionBoxWrapper1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchAuthor";
            this.Text = "SearchAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button searchButton;
        private DataGridView dataGridView;
        private SuggestionBoxUserControl.SuggestionBoxWrapper suggestionBoxWrapper1;
        private SuggestionBoxUserControl.SuggestionBoxWrapper suggestionBoxWrapper2;
    }
}