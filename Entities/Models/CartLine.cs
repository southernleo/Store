using Entities.Models;

namespace Entities.Model{
    public class CartLine{
        public int CartLineID { get; set; }
        public Product Product { get; set; }=new();
        public int Quantity{ get; set; }

    }
}