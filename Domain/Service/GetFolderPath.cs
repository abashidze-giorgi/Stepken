namespace Domain.Service
{
    public static class GetFolderPath
    {
        public static string GetLibFolderPath()
        {
            string mainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib"));
            return folderPath;
        }

        public static string GetImageFolderPath()
        {
            string mainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image"));
            return folderPath;
        }

        public static string GetCharacterFolderPath()
        {
            string mainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\Character"));
            return folderPath;
        }
        public static string GetWeaponFolderPath()
        {
            string mainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\WeaponImage"));
            return folderPath;
        }

        public static string GetShieldFolderPath()
        {
            string mainDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.GetFullPath(Path.Combine(mainDirectoryPath, @"..\..\..\..\Domain\Lib\Image\ShieldImage"));
            return folderPath;
        }
    }
}
