namespace ProductStore
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
            this.CategoriesListBx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.OrdersFormPanel = new System.Windows.Forms.Panel();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OrderButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.OrdersFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesListBx
            // 
            this.CategoriesListBx.FormattingEnabled = true;
            this.CategoriesListBx.ItemHeight = 16;
            this.CategoriesListBx.Location = new System.Drawing.Point(0, 16);
            this.CategoriesListBx.Name = "CategoriesListBx";
            this.CategoriesListBx.Size = new System.Drawing.Size(243, 340);
            this.CategoriesListBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категории";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CategoriesListBx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 344);
            this.panel1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 224);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 3;
            // 
            // OrdersFormPanel
            // 
            this.OrdersFormPanel.Controls.Add(this.OrderButton);
            this.OrdersFormPanel.Controls.Add(this.CountNumericUpDown);
            this.OrdersFormPanel.Controls.Add(this.ProductsComboBox);
            this.OrdersFormPanel.Location = new System.Drawing.Point(284, 50);
            this.OrdersFormPanel.Name = "OrdersFormPanel";
            this.OrdersFormPanel.Size = new System.Drawing.Size(292, 178);
            this.OrdersFormPanel.TabIndex = 4;
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(15, 36);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(121, 24);
            this.ProductsComboBox.TabIndex = 0;
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Location = new System.Drawing.Point(156, 37);
            this.CountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CountNumericUpDown.TabIndex = 1;
            this.CountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(96, 110);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(93, 36);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(603, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 344);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.OrdersFormPanel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OrdersFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel OrdersFormPanel;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

