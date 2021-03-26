
namespace ProjectCourse_2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDB = new System.Windows.Forms.Button();
            this.DownloadDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDB
            // 
            this.CreateDB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CreateDB.Location = new System.Drawing.Point(12, 46);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(425, 80);
            this.CreateDB.TabIndex = 0;
            this.CreateDB.Text = "Создать новую базу данных";
            this.CreateDB.UseVisualStyleBackColor = true;
            this.CreateDB.Click += new System.EventHandler(this.CreateDB_Click);
            // 
            // DownloadDB
            // 
            this.DownloadDB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DownloadDB.Location = new System.Drawing.Point(12, 176);
            this.DownloadDB.Name = "DownloadDB";
            this.DownloadDB.Size = new System.Drawing.Size(425, 80);
            this.DownloadDB.TabIndex = 1;
            this.DownloadDB.Text = "Загрузить существующую базу данных";
            this.DownloadDB.UseVisualStyleBackColor = true;
            this.DownloadDB.Click += new System.EventHandler(this.DownloadDB_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 309);
            this.Controls.Add(this.DownloadDB);
            this.Controls.Add(this.CreateDB);
            this.Name = "MainWindow";
            this.Text = "Учёт градостроительной деятельности";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDB;
        private System.Windows.Forms.Button DownloadDB;
    }
}

