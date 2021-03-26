
namespace ProjectCourse_2
{
    partial class Map
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
            this.Close = new System.Windows.Forms.Button();
            this.MapMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(1134, 719);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(190, 62);
            this.Close.TabIndex = 21;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MapMain
            // 
            this.MapMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MapMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapMain.Location = new System.Drawing.Point(12, 12);
            this.MapMain.Name = "MapMain";
            this.MapMain.Size = new System.Drawing.Size(1312, 701);
            this.MapMain.TabIndex = 22;
            this.MapMain.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 793);
            this.Controls.Add(this.MapMain);
            this.Controls.Add(this.Close);
            this.Name = "Map";
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox MapMain;
    }
}