using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodProducts
{
    public partial class MainForm : Form
    {
        private List<Product> allProducts = new List<Product>();
        private List<Product> selectedProducts = new List<Product>();
        private string currentCategory = "";
        public MainForm()
        {
            InitializeComponent();
            InitializeProducts();
            LoadCategories();
        }
        private void InitializeProducts()
        {
            allProducts.Add(new Product("Овощи", "Помидоры", 150.50m, "ООО Фермер"));
            allProducts.Add(new Product("Овощи", "Огурцы", 120.00m, "ООО Фермер"));
            allProducts.Add(new Product("Овощи", "Картофель", 80.00m, "ИП Сидоров"));
            allProducts.Add(new Product("Овощи", "Морковь", 60.00m, "ООО Фермер"));
            allProducts.Add(new Product("Овощи", "Лук", 50.00m, "ИП Сидоров"));

            allProducts.Add(new Product("Мясо", "Говядина", 450.00m, "Мясокомбинат №1"));
            allProducts.Add(new Product("Мясо", "Свинина", 380.00m, "Мясокомбинат №1"));
            allProducts.Add(new Product("Мясо", "Курица", 250.00m, "Птицефабрика"));
            allProducts.Add(new Product("Мясо", "Индейка", 350.00m, "Птицефабрика"));
            allProducts.Add(new Product("Мясо", "Баранина", 480.00m, "Мясокомбинат №1"));
        }
        private void LoadCategories()
        {
            listBox.Items.Clear();
            listBox.Items.Add("Овощи");
            listBox.Items.Add("Мясо");
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                currentCategory = listBox.SelectedItem.ToString();

                comboBoxProduct.Items.Clear();

                foreach (Product product in allProducts)
                {
                    if (product.Category == currentCategory)
                    {
                        comboBoxProduct.Items.Add(product.Name);
                    }
                }
            }
        }
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null && !string.IsNullOrEmpty(currentCategory))
            {
                string selectedProductName = comboBoxProduct.SelectedItem.ToString();
                Product selectedProduct = allProducts.Find(p =>
                    p.Category == currentCategory && p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    ShowProductInfo(selectedProduct);
                }
            }
        }
        private void ShowProductInfo(Product product)
        {
            richTextBoxInfo.Text =
                $"=== КАРТОЧКА ТОВАРА ===\n\n" +
                $"Название: {product.Name}\n" +
                $"Категория: {product.Category}\n" +
                $"Цена: {product.Price} руб.\n" +
                $"Поставщик: {product.Supplier}\n" +
                $"Производитель: {product.Manufacturer}\n" +
                $"Срок годности: {product.ExpiryDate.ToShortDateString()}\n\n" +
                $"Вы выбрали: {ProductQuantity.Value} шт.\n" +
                $"Итого: {product.Price * (int)ProductQuantity.Value} руб.";
        }
        private void ProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null)
            {
                comboBoxProduct_SelectedIndexChanged(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem == null || string.IsNullOrEmpty(currentCategory))
            {
                MessageBox.Show("Выберите продукт!");
                return;
            }

            string selectedProductName = comboBoxProduct.SelectedItem.ToString();
            int quantity = (int)ProductQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Выберите количество больше 0!");
                return;
            }

            Product productToAdd = allProducts.Find(p =>p.Category == currentCategory && p.Name == selectedProductName);

            if (productToAdd != null)
            {
                Product orderedProduct = new Product(
                    productToAdd.Category,
                    productToAdd.Name,
                    productToAdd.Price,
                    productToAdd.Supplier
                );

                orderedProduct.Quantity = quantity;

                selectedProducts.Add(orderedProduct);
                ShowFinalOrder();
                ProductQuantity.Value = 0;
            }
        }
        private void ShowFinalOrder()
        {
            string orderText = "ИТОГО\n\n";
            decimal total = 0;
            for (int i = 0; i < selectedProducts.Count; i++)
            {
                Product product = selectedProducts[i];
                orderText += $"{i + 1}. {product.GetOrderInfo()}\n";
                total += product.Price * product.Quantity;
            }

            

            richTextBoxInfo.Text = orderText;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem == null || string.IsNullOrEmpty(currentCategory))
            {
                MessageBox.Show("Выберите продукт!");
                return;
            }

            string selectedProductName = comboBoxProduct.SelectedItem.ToString();
            int quantity = (int)ProductQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Выберите количество больше 0!");
                return;
            }

            Product productToAdd = allProducts.Find(p =>p.Category == currentCategory && p.Name == selectedProductName);

            if (productToAdd != null)
            {
                Product orderedProduct = new Product(
                    productToAdd.Category,
                    productToAdd.Name,
                    productToAdd.Price,
                    productToAdd.Supplier
                );

                orderedProduct.Quantity = quantity;
                selectedProducts.Add(orderedProduct);
                ShowFinalOrder();
                ProductQuantity.Value = 0;
            }
        }
    }
}
