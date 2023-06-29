using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Client_Project_Design.Models
{
    public class Order
    {
        



        


        public string Delivery { get; set; }
        public string Opening { get; set; }


        private bool _isdelivered;

        public bool IsDelivered
        {
            get { return _isdelivered; }
            set { _isdelivered = value; }
        }



        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }



        private DateTime _opening;

        public DateTime OpeningDate
        {
            get { return _opening; }
            set { _opening = value;  }
        }




        private DateTime _delivery;

        public DateTime DeliveryDate
        {
            get { return _delivery; }
            set { _delivery = value; }
        }




        private string? _name;

        public string? OrderName
        {
            get { return _name; }
            set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Order Name"); 
                _name = value; }
        }


        private uint _quantity;

        public uint Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string CircleColor { get
            {
                if (IsDelivered)  return "#07DA42";
                return "#EE0F0F";
            }
        }

        public Order() { }

        public Order(Guid id, string? orderName, uint quantity, string d,string m,string y,string dd,string mm,string yy,bool isDelivered=false)
        {
            
            Id = id;
            OrderName = orderName;
            Quantity = quantity;
            OpeningDate = new(Convert.ToInt32(y), Convert.ToInt32(m), Convert.ToInt32(d)); ;
            DeliveryDate = new(Convert.ToInt32(yy), Convert.ToInt32(mm), Convert.ToInt32(dd));
            Delivery = DeliveryDate.ToShortDateString();
            Opening = OpeningDate.ToShortDateString();
            IsDelivered = isDelivered;
            
        }
    }
}
