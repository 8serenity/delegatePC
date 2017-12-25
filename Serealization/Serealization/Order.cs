using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serealization
{
    [Serializable]
    public class Order
    {
        [NonSerialized]
        private Guid id;
        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }





        public string FoodName { get; set; }
        public int Place { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }

    }
}
