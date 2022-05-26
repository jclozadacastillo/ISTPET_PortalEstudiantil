namespace ISTPET_PortalEstudiantil.Auth
{
    public interface ISessionAlumnos
    {
        string getUser();

        string getName();

        void set(string key, string value);

        string get(string key);

        bool isLogged();

        bool inRol(string rol);

        Task<bool> logoutAsync();
        bool logoutSync();

    }
}