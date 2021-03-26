
namespace ProjectCourse_2
{
    partial class NameorIdSearchResultR
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
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseSearch = new System.Windows.Forms.Button();
            this.ToMap = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Enabled = false;
            this.ExtraInfo.Location = new System.Drawing.Point(12, 193);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(776, 114);
            this.ExtraInfo.TabIndex = 24;
            this.ExtraInfo.Text = "";
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(200, 52);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Наименование:\r\n";
            // 
            // CloseSearch
            // 
            this.CloseSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseSearch.Location = new System.Drawing.Point(598, 335);
            this.CloseSearch.Name = "CloseSearch";
            this.CloseSearch.Size = new System.Drawing.Size(190, 62);
            this.CloseSearch.TabIndex = 34;
            this.CloseSearch.Text = "Закрыть";
            this.CloseSearch.UseVisualStyleBackColor = true;
            this.CloseSearch.Click += new System.EventHandler(this.CloseSearch_Click);
            // 
            // ToMap
            // 
            this.ToMap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMap.Location = new System.Drawing.Point(373, 335);
            this.ToMap.Name = "ToMap";
            this.ToMap.Size = new System.Drawing.Size(190, 62);
            this.ToMap.TabIndex = 33;
            this.ToMap.Text = "Посмотреть на карте";
            this.ToMap.UseVisualStyleBackColor = true;
            this.ToMap.Click += new System.EventHandler(this.ToMap_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.Enabled = false;
            this.TypeBox.Location = new System.Drawing.Point(200, 111);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(234, 22);
            this.TypeBox.TabIndex = 35;
            // 
            // NameorIdSearchResultR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CloseSearch);
            this.Controls.Add(this.ToMap);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "NameorIdSearchResultR";
            this.Text = "Результат поиска";
            this.Load += new System.EventHandler(this.NameorIdSearchResultR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseSearch;
        private System.Windows.Forms.Button ToMap;
        private System.Windows.Forms.TextBox TypeBox;
    }
}