
namespace ProjectCourse_2
{
    partial class NameorIdSearch
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
            this.HeadersFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelSearchNId = new System.Windows.Forms.Button();
            this.SearchNId = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadersFilter
            // 
            this.HeadersFilter.FormattingEnabled = true;
            this.HeadersFilter.Location = new System.Drawing.Point(210, 26);
            this.HeadersFilter.Name = "HeadersFilter";
            this.HeadersFilter.Size = new System.Drawing.Size(234, 24);
            this.HeadersFilter.TabIndex = 0;
            this.HeadersFilter.SelectedIndexChanged += new System.EventHandler(this.HeadersFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Категория:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.Input);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 161);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Location = new System.Drawing.Point(194, 38);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(234, 24);
            this.Filter.TabIndex = 30;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(194, 109);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(234, 22);
            this.Input.TabIndex = 33;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Введите значение:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Опция:\r\n";
            // 
            // CancelSearchNId
            // 
            this.CancelSearchNId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelSearchNId.Location = new System.Drawing.Point(254, 274);
            this.CancelSearchNId.Name = "CancelSearchNId";
            this.CancelSearchNId.Size = new System.Drawing.Size(190, 62);
            this.CancelSearchNId.TabIndex = 29;
            this.CancelSearchNId.Text = "Отменить";
            this.CancelSearchNId.UseVisualStyleBackColor = true;
            this.CancelSearchNId.Click += new System.EventHandler(this.CancelSearchNId_Click);
            // 
            // SearchNId
            // 
            this.SearchNId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchNId.Location = new System.Drawing.Point(30, 274);
            this.SearchNId.Name = "SearchNId";
            this.SearchNId.Size = new System.Drawing.Size(190, 62);
            this.SearchNId.TabIndex = 28;
            this.SearchNId.Text = "Поиск";
            this.SearchNId.UseVisualStyleBackColor = true;
            this.SearchNId.Click += new System.EventHandler(this.SearchNId_Click);
            // 
            // NameorIdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 357);
            this.Controls.Add(this.CancelSearchNId);
            this.Controls.Add(this.SearchNId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeadersFilter);
            this.Name = "NameorIdSearch";
            this.Text = "Поиск по имени или id";
            this.Load += new System.EventHandler(this.NameorIdSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HeadersFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelSearchNId;
        private System.Windows.Forms.Button SearchNId;
        private System.Windows.Forms.ComboBox Filter;
    }
}