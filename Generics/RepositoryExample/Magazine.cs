using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public class Magazine: Entity
    {
        public string Name { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Price { get; set; }
    }
}
