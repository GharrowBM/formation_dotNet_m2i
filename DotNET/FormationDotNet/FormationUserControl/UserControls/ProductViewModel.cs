using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationUserControl.UserControls
{
    public class ProductViewModel
    {
        private string title;
        private decimal price;

        public string Title { get => title; set => title = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
