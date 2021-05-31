using System.IO;
using Lab13.Droid.Implementations;
using Lab13.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab13.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), 
                databaseFileName);
        }
    }
}