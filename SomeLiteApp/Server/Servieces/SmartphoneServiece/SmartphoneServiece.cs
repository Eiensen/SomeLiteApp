namespace SomeLiteApp.Server.Servieces.SmartphoneServiece
{
    public class SmartphoneServiece : ISmartphoneServiece
    {
        private readonly DataContext _context;

        public SmartphoneServiece(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Smartphone>> GetAllAsync()
        {
            var smartphones =  await _context.Smartphones.ToListAsync();

            return smartphones;
        }
    }
}
