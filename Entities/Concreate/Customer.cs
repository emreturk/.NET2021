using Core.Entities.Abstract;

namespace Entities.Concreate
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        

    }
}
