using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjecs 
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

             AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName","O nome deve ter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName","O último nome deve ter pelo menos 3 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}