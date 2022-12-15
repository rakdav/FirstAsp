namespace FirstAsp.Models
{
    public interface IPartyRepository
    {
        IQueryable<GuestResponse> GetResponses { get; }
    }
}
