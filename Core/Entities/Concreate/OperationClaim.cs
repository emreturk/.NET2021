using Core.Entities.Abstract;

namespace Core.Entities.Concreate
{
    public class OperationClaim : IEntity
    {
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }

    }
}