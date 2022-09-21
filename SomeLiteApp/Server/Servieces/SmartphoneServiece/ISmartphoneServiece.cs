namespace SomeLiteApp.Server.Servieces.SmartphoneServiece
{
    public interface ISmartphoneServiece
    {
        Task<List<Smartphone>> GetAllAsync();
    }
}
