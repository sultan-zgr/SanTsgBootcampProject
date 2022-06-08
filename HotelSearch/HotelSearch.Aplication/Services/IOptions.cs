using HotelSearch.Shared.SettingsModels;

namespace HotelSearch.Application.Services
{
    public interface IOptions<T>
    {
        EmailSettings Value { get; set; }
    }
}