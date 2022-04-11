namespace BalanceManager.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id_role { get; set; }
        public float USD_balance { get; set; }
        public virtual Role Role { get; set; }
    }
}
