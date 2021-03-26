
namespace ProjectCourse_2
{
    partial class CreateLandscape
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТипахЛандшафтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConButtonLS = new System.Windows.Forms.Button();
            this.CancelButtonLS = new System.Windows.Forms.Button();
            this.DeleteElem = new System.Windows.Forms.Button();
            this.ChangeElem = new System.Windows.Forms.Button();
            this.AddElem = new System.Windows.Forms.Button();
            this.LSTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.картаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.базаДанныхToolStripMenuItem.Text = "Изменить";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить элемент ландшафта";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить элемент ландшафта";
            this.изменитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить элемент ландшафта";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКартуToolStripMenuItem});
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.картаToolStripMenuItem.Text = "Карта";
            // 
            // посмотретьКартуToolStripMenuItem
            // 
            this.посмотретьКартуToolStripMenuItem.Name = "посмотретьКартуToolStripMenuItem";
            this.посмотретьКартуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.посмотретьКартуToolStripMenuItem.Text = "Посмотреть карту";
            this.посмотретьКартуToolStripMenuItem.Click += new System.EventHandler(this.посмотретьКартуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оТипахЛандшафтаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оТипахЛандшафтаToolStripMenuItem
            // 
            this.оТипахЛандшафтаToolStripMenuItem.Name = "оТипахЛандшафтаToolStripMenuItem";
            this.оТипахЛандшафтаToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.оТипахЛандшафтаToolStripMenuItem.Text = "О типах ландшафта";
            this.оТипахЛандшафтаToolStripMenuItem.Click += new System.EventHandler(this.оТипахЛандшафтаToolStripMenuItem_Click);
            // 
            // ConButtonLS
            // 
            this.ConButtonLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConButtonLS.Location = new System.Drawing.Point(11, 498);
            this.ConButtonLS.Name = "ConButtonLS";
            this.ConButtonLS.Size = new System.Drawing.Size(190, 62);
            this.ConButtonLS.TabIndex = 10;
            this.ConButtonLS.Text = "Подтвердить изменения";
            this.ConButtonLS.UseVisualStyleBackColor = true;
            this.ConButtonLS.Click += new System.EventHandler(this.ConButtonLS_Click);
            // 
            // CancelButtonLS
            // 
            this.CancelButtonLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButtonLS.Location = new System.Drawing.Point(934, 498);
            this.CancelButtonLS.Name = "CancelButtonLS";
            this.CancelButtonLS.Size = new System.Drawing.Size(190, 62);
            this.CancelButtonLS.TabIndex = 11;
            this.CancelButtonLS.Text = "Отмена";
            this.CancelButtonLS.UseVisualStyleBackColor = true;
            this.CancelButtonLS.Click += new System.EventHandler(this.CancelButtonLS_Click);
            // 
            // DeleteElem
            // 
            this.DeleteElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElem.Location = new System.Drawing.Point(705, 498);
            this.DeleteElem.Name = "DeleteElem";
            this.DeleteElem.Size = new System.Drawing.Size(190, 62);
            this.DeleteElem.TabIndex = 20;
            this.DeleteElem.Text = "Удалить элемент";
            this.DeleteElem.UseVisualStyleBackColor = true;
            this.DeleteElem.Click += new System.EventHandler(this.DeleteElem_Click);
            // 
            // ChangeElem
            // 
            this.ChangeElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeElem.Location = new System.Drawing.Point(472, 498);
            this.ChangeElem.Name = "ChangeElem";
            this.ChangeElem.Size = new System.Drawing.Size(190, 62);
            this.ChangeElem.TabIndex = 19;
            this.ChangeElem.Text = "Изменить элемент";
            this.ChangeElem.UseVisualStyleBackColor = true;
            this.ChangeElem.Click += new System.EventHandler(this.ChangeElem_Click);
            // 
            // AddElem
            // 
            this.AddElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElem.Location = new System.Drawing.Point(243, 498);
            this.AddElem.Name = "AddElem";
            this.AddElem.Size = new System.Drawing.Size(190, 62);
            this.AddElem.TabIndex = 18;
            this.AddElem.Text = "Добавить элемент";
            this.AddElem.UseVisualStyleBackColor = true;
            this.AddElem.Click += new System.EventHandler(this.AddElem_Click);
            // 
            // LSTable
            // 
            this.LSTable.AllowUserToAddRows = false;
            this.LSTable.AllowUserToDeleteRows = false;
            this.LSTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LSTable.Location = new System.Drawing.Point(12, 64);
            this.LSTable.Name = "LSTable";
            this.LSTable.ReadOnly = true;
            this.LSTable.RowHeadersWidth = 51;
            this.LSTable.RowTemplate.Height = 24;
            this.LSTable.Size = new System.Drawing.Size(1112, 376);
            this.LSTable.TabIndex = 26;
            // 
            // CreateLandscape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 572);
            this.Controls.Add(this.LSTable);
            this.Controls.Add(this.DeleteElem);
            this.Controls.Add(this.ChangeElem);
            this.Controls.Add(this.AddElem);
            this.Controls.Add(this.CancelButtonLS);
            this.Controls.Add(this.ConButtonLS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateLandscape";
            this.Text = "Ландшафт";
            this.Load += new System.EventHandler(this.CreateLandscape_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКартуToolStripMenuItem;
        private System.Windows.Forms.Button ConButtonLS;
        private System.Windows.Forms.Button CancelButtonLS;
        private System.Windows.Forms.Button DeleteElem;
        private System.Windows.Forms.Button ChangeElem;
        private System.Windows.Forms.Button AddElem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТипахЛандшафтаToolStripMenuItem;
        private System.Windows.Forms.DataGridView LSTable;
    }
}