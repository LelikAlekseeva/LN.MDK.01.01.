using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStorApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Product>> productGroups = new Dictionary<string, List<Product>>();
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
