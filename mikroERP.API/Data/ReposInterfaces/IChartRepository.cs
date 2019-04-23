using System.Threading.Tasks;

namespace mikroERP.API.Data
{
    public interface IChartRepository
    {
         int GetWomanCount();
         int GetManCount();
         int GetManagmentDepCount();
         int GetLogisticsDepCount();
         int GetAdministrationDepCount();
         int GetMarketingDepCount();
    }
}