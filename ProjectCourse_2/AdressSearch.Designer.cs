
namespace ProjectCourse_2
{
    partial class AdressSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StreetFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelSearch = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StreetFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NumBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 167);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // StreetFilter
            // 
            this.StreetFilter.FormattingEnabled = true;
            this.StreetFilter.Location = new System.Drawing.Point(151, 56);
            this.StreetFilter.Name = "StreetFilter";
            this.StreetFilter.Size = new System.Drawing.Size(234, 24);
            this.StreetFilter.TabIndex = 23;
            this.StreetFilter.SelectedIndexChanged += new System.EventHandler(this.StreetFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Улица:\r\n";
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(151, 115);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(234, 22);
            this.NumBox.TabIndex = 22;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер:\r\n";
            // 
            // CancelSearch
            // 
            this.CancelSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSearch.Location = new System.Drawing.Point(246, 210);
            this.CancelSearch.Name = "CancelSearch";
            this.CancelSearch.Size = new System.Drawing.Size(190, 62);
            this.CancelSearch.TabIndex = 27;
            this.CancelSearch.Text = "Отменить";
            this.CancelSearch.UseVisualStyleBackColor = true;
            this.CancelSearch.Click += new System.EventHandler(this.CancelSearch_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(22, 210);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(190, 62);
            this.Search.TabIndex = 26;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AdressSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 284);
            this.Controls.Add(this.CancelSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdressSearch";
            this.Text = "Поиск по адресу";
            this.Load += new System.EventHandler(this.AdressSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StreetFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelSearch;
        private System.Windows.Forms.Button Search;
    }
}