namespace Domain.Interface
{
    public interface ISaveAndLoadGame
    {
        public bool Save();
        public void Load(string userName);
    }
}
