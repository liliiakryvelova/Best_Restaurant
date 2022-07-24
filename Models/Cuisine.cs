using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public Cuisine()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
    }
}