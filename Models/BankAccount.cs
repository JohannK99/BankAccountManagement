namespace BankAccountManagement.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string? AccountHolder { get; set; } // Nombre del titular
        public string? AccountType { get; set; } // Tipo de cuenta (por ejemplo, "Checking" o "Savings")
        public decimal InitialBalance { get; set; } // Saldo inicial
        public string? Email { get; set; } // Correo electrónico del titular
    }
}
