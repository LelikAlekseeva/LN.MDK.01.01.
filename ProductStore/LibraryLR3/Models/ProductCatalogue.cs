using System.Collections.Generic;
using System.Linq;

namespace ProductStore.Models
{
    public class ProductsCatalogue
    {
        /// <summary>
        /// ключом словаря является название категории товарной группы(категории)
        /// значением список товаров , относящихся к конкретной группе
        /// </summary>
        private Dictionary<string, List<Product>> data_ = new Dictionary<string, List<Product>>();

        public void AddProducts(string groupName, List<Product> products)
        {
            if (data_.ContainsKey(groupName))
            {
                data_[groupName].AddRange(products);
            }
            else
            {
                data_.Add(groupName, products);
            }
        }
        public List<string> GetAllGroups()//список всех групп
        {
            return data_.Keys.ToList();
        }
        public List<Product> GetProductsByGroup(string groupName)//список всех товаров определённой группы
        {
            if (data_.ContainsKey(groupName))
            {
                return data_[groupName];
            }
            return null;

        }
    }
}  