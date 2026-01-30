namespace FoodStorApp
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.IstGroups = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.IblQuatity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblFinalOrder = new System.Windows.Forms.Label();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(20, 20);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(88, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Группы товаров";
            // 
            // IstGroups
            // 
            this.IstGroups.FormattingEnabled = true;
            this.IstGroups.Location = new System.Drawing.Point(20, 45);
            this.IstGroups.Name = "IstGroups";
            this.IstGroups.Size = new System.Drawing.Size(150, 108);
            this.IstGroups.TabIndex = 1;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(190, 20);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(46, 13);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Товары";
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(190, 45);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(200, 21);
            this.cmbProducts.TabIndex = 3;
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Location = new System.Drawing.Point(190, 85);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(120, 13);
            this.lblProductInfo.TabIndex = 4;
            this.lblProductInfo.Text = "Информация о товаре";
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.LightGray;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(190, 110);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(100, 100);
            this.picProduct.TabIndex = 5;
            this.picProduct.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(300, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(100, 32);
            this.txtDescription.TabIndex = 6;
            // 
            // IblQuatity
            // 
            this.IblQuatity.AutoSize = true;
            this.IblQuatity.Location = new System.Drawing.Point(520, 45);
            this.IblQuatity.Name = "IblQuatity";
            this.IblQuatity.Size = new System.Drawing.Size(66, 13);
            this.IblQuatity.TabIndex = 7;
            this.IblQuatity.Text = "Количество";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(520, 45);
            this.nudQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 20);
            this.nudQuantity.TabIndex = 8;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(520, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить в заказ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(12, 236);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentOrder.TabIndex = 10;
            this.lblCurrentOrder.Text = "Текущий заказ:";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(116, 236);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(120, 95);
            this.lstOrder.TabIndex = 11;
            // 
            // lblFinalOrder
            // 
            this.lblFinalOrder.AutoSize = true;
            this.lblFinalOrder.Location = new System.Drawing.Point(255, 236);
            this.lblFinalOrder.Name = "lblFinalOrder";
            this.lblFinalOrder.Size = new System.Drawing.Size(93, 13);
            this.lblFinalOrder.TabIndex = 12;
            this.lblFinalOrder.Text = "Итоговый заказ:";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.LightGray;
            this.btnMakeOrder.Location = new System.Drawing.Point(76, 394);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(120, 40);
            this.btnMakeOrder.TabIndex = 13;
            this.btnMakeOrder.Text = "Оформить заказ";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Location = new System.Drawing.Point(280, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить заказ";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(500, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.lblFinalOrder);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.IblQuatity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.IstGroups);
            this.Controls.Add(this.lblGroup);
            this.Name = "Form1";
            this.Text = "Магазин продуктов - заказ товаров";
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ListBox IstGroups;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label IblQuatity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblFinalOrder;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

