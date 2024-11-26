using Proyecto.Model;

namespace Proyecto.Controller.DataHandler
{
    public interface IFileDataHandler
    {
        List<User> GetTrainers();
        User Login(string username, int password);
        void RegisterUser(User user);
    }
}