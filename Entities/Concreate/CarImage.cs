using Core.Entities.Abstract;
using System;

namespace Entities.Concreate
{
    public class CarImage : IEntity
    {

        public int CarImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
