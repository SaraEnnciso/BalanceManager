namespace BalanceManager.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id_role { get; set; }
        public double? USD_balance { get; set; }
        public virtual RoleDTO RoleDTO { get; set; }
    }
}