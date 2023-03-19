using Newtonsoft.Json;
using Domain.GameCharacter;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace Domain.Service
{
    public class CreateNewUser
    {
        public bool CreateUser(string userName)
        {
            bool created = false;
            try
            {
                // check if name exist
                bool notExist = CheckUserExist(userName, out int userCount);
                //if not exist
                if (notExist)
                {
                    // call saveNewUser and if it return true
                    if(SaveNewUser(userName, userCount))
                    {
                        created = true;
                        return created;
                    }
                }
                return created;
            }
            catch (Exception ex)
            {
                return created;
            }
        }

        private bool CheckUserExist(string userName, out int userCount)
        {
            StringCollection stringList = Settings.Settings1.Default.PlayerS; // get list from settings
            if(stringList == null)
            {
                userCount = 0;
                return false;
            }
            else
            {
                List<Character> myList = new List<Character>();
                foreach (string characterJson in stringList)
                {
                    var character = JsonConvert.DeserializeObject<Character>(characterJson);
                    myList.Add(character);
                }
                var player = myList.Where(p => p.Name ==  userName).FirstOrDefault();
                userCount = myList.Count();
                return player == null ? true : false;
            }
        }

        private bool SaveNewUser(string userName, int userCount)
        {
            bool saved = false;
            try
            {
                List<Character> myList = new List<Character>(); // new character list
                StringCollection stringList = new StringCollection();// new list of collections.specialized.string.list

                string characterJson = JsonConvert.SerializeObject(CreateCharacter(userName, userCount));
                stringList.Add(characterJson);

                Domain.Settings.Settings1.Default.PlayerS = stringList;
                Domain.Settings.Settings1.Default.Save();
                saved = true;
                return saved;
            }
            catch (Exception ex)
            {
                return saved;
            }
        }

        private Character CreateCharacter(string userName, int userId)
        {
            var player = new Character(userId+1, userName, 350, 40, 40,
                CharacterRaceEnum.Human, Model.Character.LevelModel.Level_1,
                $"{GetFolderPath.GetCharacterFolderPath()}\\human.jpg");
            player.Weapon.Add(GameList.WeaponList[GetRandomWeaponId()]);
            player.Shield = GameList.ShieldList[4];
            GameList.Player = player;
            return player;
        }
       
        private int GetRandomWeaponId()
        {
            var random = new Random();
            int weaponId = (int)random.Next(0, GameList.WeaponList.Count);
            return weaponId;
        }
    }
}
