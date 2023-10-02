using API_TeamsData.Models;

namespace API_TeamsData.Interfaces

{
    public interface ITimesRepository
    {
        public List<Times> BuscaTodosTimes();
    }
}
