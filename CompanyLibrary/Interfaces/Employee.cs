namespace CompanyLibrary.Interfaces
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Seniority { get; set; } //months
        public abstract string Work();

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic}, стаж: {Seniority} мес.";
        }
    }
}
