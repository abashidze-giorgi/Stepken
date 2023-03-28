using Domain.GameCharacter;

namespace Domain.Service
{
    public static class GetFolderPath
    {
        private static string GetMainDirectoryPath()
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectoryPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(directoryPath)))));

            return parentDirectoryPath;
        }
        public static string GetLibFolderPath()
        {
            string mainDirectoryPath = GetMainDirectoryPath();
            string folderPath = Path.Combine(mainDirectoryPath, "Domain", "Lib");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib"));
            return folderPath;
        }

        public static string GetImageFolderPath()
        {
            string mainDirectoryPath = GetMainDirectoryPath();
            string folderPath = Path.Combine(mainDirectoryPath, "Domain", "Lib", "Image");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image"));
            return folderPath;
        }

        public static string GetCharacterFolderPath()
        {
            string mainDirectoryPath = GetMainDirectoryPath();
            string folderPath = Path.Combine(mainDirectoryPath, "Domain", "Lib", "Image", "Character");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\Character"));
            return folderPath;
        }
        public static string GetWeaponFolderPath() 
        {
            string mainDirectoryPath = GetMainDirectoryPath();
            string folderPath = Path.Combine(mainDirectoryPath, "Domain", "Lib", "Image", "WeaponImage");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\WeaponImage"));
            return folderPath;
        }

        public static string GetShieldFolderPath()
        {
            string mainDirectoryPath = GetMainDirectoryPath();
            string folderPath = Path.Combine(mainDirectoryPath, "Domain", "Lib", "Image", "ShieldImage");
            //string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\ShieldImage"));
            return folderPath;
        }
    }
}
