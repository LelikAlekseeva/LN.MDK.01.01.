namespace MovieRental
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ListBoxGenre = new System.Windows.Forms.ListBox();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.pictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.LabelText = new System.Windows.Forms.Label();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.NumericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGenre
            // 
            this.ListBoxGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxGenre.FormattingEnabled = true;
            this.ListBoxGenre.Location = new System.Drawing.Point(0, 0);
            this.ListBoxGenre.Name = "ListBoxGenre";
            this.ListBoxGenre.Size = new System.Drawing.Size(168, 450);
            this.ListBoxGenre.TabIndex = 0;
            this.ListBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(174, 113);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(241, 32);
            this.comboBoxMovie.TabIndex = 1;
            this.comboBoxMovie.SelectedIndexChanged += new System.EventHandler(this.comboBoxMovie_SelectedIndexChanged_1);
            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.Location = new System.Drawing.Point(441, 0);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new System.Drawing.Size(356, 263);
            this.pictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilm.TabIndex = 2;
            this.pictureBoxFilm.TabStop = false;
            // 
            // ButtonReport
            // 
            this.ButtonReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReport.Location = new System.Drawing.Point(224, 322);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(114, 61);
            this.ButtonReport.TabIndex = 3;
            this.ButtonReport.Text = "Отчёт";
            this.ButtonReport.UseVisualStyleBackColor = false;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelText.Location = new System.Drawing.Point(197, 45);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(184, 25);
            this.LabelText.TabIndex = 4;
            this.LabelText.Text = "Выберите фильм";
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Location = new System.Drawing.Point(432, 280);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(356, 158);
            this.RichTextBoxInfo.TabIndex = 5;
            this.RichTextBoxInfo.Text = "";
            // 
            // NumericUpDownValue
            // 
            this.NumericUpDownValue.Location = new System.Drawing.Point(216, 235);
            this.NumericUpDownValue.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDownValue.Name = "NumericUpDownValue";
            this.NumericUpDownValue.Size = new System.Drawing.Size(154, 20);
            this.NumericUpDownValue.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumericUpDownValue);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.pictureBoxFilm);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.ListBoxGenre);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Показ фильмов в кинотеатре";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.PictureBox pictureBoxFilm;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
        private System.Windows.Forms.NumericUpDown NumericUpDownValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

