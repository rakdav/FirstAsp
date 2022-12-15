namespace FirstAsp.Models
{
    public class EFPartyRepository:IPartyRepository
    {
        private PartyDbContext context;

        public EFPartyRepository(PartyDbContext context)
        {
            this.context = context;
        }

        public IQueryable<GuestResponse> GetResponses => context.GuestResponses;
    }
}
