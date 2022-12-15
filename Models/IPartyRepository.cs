namespace FirstAsp.Models
{
    public interface IPartyRepository
    {
        IQueryable<GuestResponse> Responses { get; }
        void SaveGuest(GuestResponse p);
        void CreateGuest(GuestResponse p);
        void DeleteGuest(GuestResponse p);
    }
}
