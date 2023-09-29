namespace DevFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public UserSkill(int idUser, int IdSkill) 
        {
            IdUser = idUser;
            IdSkill = IdSkill;
   
        }
        public int IdUser { get; private set; }
        public int IdSkill { get; private set; }
    }
}