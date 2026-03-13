using LinqToDB.Mapping;

namespace WorkSpace18._02._26.Models
{
    public class Client
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }

        public Client(string name, string email, string phoneNumber, string address)
        {
            CheckNotNullOrWhiteSpace(name, "Ожидается не пустое имя");
            CheckNotNullOrWhiteSpace(email, "Ожидается не пустой email");
            CheckNotNullOrWhiteSpace(phoneNumber, "Ожидается не пустой номер телефона");
            CheckNotNullOrWhiteSpace(address, "Ожидается не пустой адрес");

            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            Name = name;
        }

        public static void CheckNotNullOrWhiteSpace(string name, string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(message, nameof(name));
            }
        }

        public void AddBalance(double balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Ожидается положительный баланс");
            }

            Balance += balance;

        }

        public void UpdateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException("Ожидается корректная почта");

            }
            Email = email;

        }



        public void UpdatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("Ожидается корректный номер телефона");
            }
            PhoneNumber = phoneNumber;
        }

        public void UpdateAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Ожидается корректный адрес");
            }
            Address = address;
        }

        public override string ToString()
        {
            return $"{Name}, баланс: {Balance}, почта: {Email}, телефон: {PhoneNumber}, адрес: {Address}";

        }

    
    }
}
