namespace SomeLiteApp.Client.Servieces
{
    public interface ISmartphoneServiece
    {
        List<Smartphone> Smartphones { get; set; }

        Task GetSmartphones();
    }
}
