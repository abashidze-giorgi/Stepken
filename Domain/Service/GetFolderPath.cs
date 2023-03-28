using Domain.GameCharacter;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Service
{
    public static class GetFolderPath
    {
        private static string GetLibPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string libDirectory = Path.Combine(baseDirectory, "Lib");

            if (Directory.Exists(libDirectory))
            {
                // Found the "Lib" directory
                Console.WriteLine("Found Lib directory at: " + libDirectory);
            }
            else
            {
                // Did not find the "Lib" directory
                Console.WriteLine("Could not find Lib directory");
            }
            return libDirectory;
        }
        
        public static string GetLibFolderPath()
        {
            string libPath = GetLibPath();
            string folderPath = libPath;
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib"));
            return folderPath;
        }

        public static string GetImageFolderPath()
        {
            string libPath = GetLibPath();
            string folderPath = Path.Combine(libPath, "Image");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image"));
            return folderPath;
        }

        public static string GetCharacterFolderPath()
        {
            string libPath = GetLibPath();
            string folderPath = Path.Combine(libPath, "Image", "Character");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\Character"));
            return folderPath;
        }
        public static string GetWeaponFolderPath() 
        {
            string libPath = GetLibPath();
            string folderPath = Path.Combine(libPath, "Image", "WeaponImage");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\WeaponImage"));
            return folderPath;
        }

        public static string GetShieldFolderPath()
        {
            string libPath = GetLibPath();
            string folderPath = Path.Combine(libPath, "Image", "ShieldImage");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\ShieldImage"));
            return folderPath;
        }
    }
}
