
namespace ProjectCourse_2
{
    partial class AddObj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObj));
            this.CancelAddObj = new System.Windows.Forms.Button();
            this.ToDraswingObj = new System.Windows.Forms.Button();
            this.UFilter = new System.Windows.Forms.ComboBox();
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetFilter = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelAddObj
            // 
            this.CancelAddObj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddObj.Location = new System.Drawing.Point(702, 464);
            this.CancelAddObj.Name = "CancelAddObj";
            this.CancelAddObj.Size = new System.Drawing.Size(190, 62);
            this.CancelAddObj.TabIndex = 19;
            this.CancelAddObj.Text = "Отменить";
            this.CancelAddObj.UseVisualStyleBackColor = true;
            this.CancelAddObj.Click += new System.EventHandler(this.CancelAddObj_Click);
            // 
            // ToDraswingObj
            // 
            this.ToDraswingObj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingObj.Location = new System.Drawing.Point(477, 464);
            this.ToDraswingObj.Name = "ToDraswingObj";
            this.ToDraswingObj.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingObj.TabIndex = 18;
            this.ToDraswingObj.Text = "Продолжить";
            this.ToDraswingObj.UseVisualStyleBackColor = true;
            this.ToDraswingObj.Click += new System.EventHandler(this.ToDraswingObj_Click);
            // 
            // UFilter
            // 
            this.UFilter.FormattingEnabled = true;
            this.UFilter.Location = new System.Drawing.Point(200, 243);
            this.UFilter.Name = "UFilter";
            this.UFilter.Size = new System.Drawing.Size(234, 24);
            this.UFilter.TabIndex = 17;
            this.UFilter.SelectedIndexChanged += new System.EventHandler(this.UFilter_SelectedIndexChanged);
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Location = new System.Drawing.Point(12, 325);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(880, 114);
            this.ExtraInfo.TabIndex = 16;
            this.ExtraInfo.Text = "";
            this.ExtraInfo.TextChanged += new System.EventHandler(this.ExtraInfo_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(200, 184);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 15;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование:\r\n";
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
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(151, 115);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(234, 22);
            this.Num.TabIndex = 22;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StreetFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(452, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(876, 66);
            this.label6.TabIndex = 25;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // AddObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelAddObj);
            this.Controls.Add(this.ToDraswingObj);
            this.Controls.Add(this.UFilter);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddObj";
            this.Text = "Добавить элемент";
            this.Load += new System.EventHandler(this.AddObj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddObj;
        private System.Windows.Forms.Button ToDraswingObj;
        private System.Windows.Forms.ComboBox UFilter;
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StreetFilter;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
    }
}