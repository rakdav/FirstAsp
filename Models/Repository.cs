namespace FirstAsp.Models
{
    public class Repository:IPartyRepository
    {
        private PartyDbContext context;

        public Repository(PartyDbContext context)
        {
            this.context = context;
        }

        public IQueryable<GuestResponse> Responses => context.GuestResponses;


        public void CreateGuest(GuestResponse p)
        {
            context.GuestResponses.Add(p);
            context.SaveChanges();
        }

        public void DeleteGuest(GuestResponse p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveGuest(GuestResponse p)
        {
            context.SaveChanges();
        }
    }
}
