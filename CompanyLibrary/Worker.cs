using CompanyLibrary.Interfaces;

namespace CompanyLibrary
{
    public class Worker : Employee
    {
        public override string Work()
        {
            return "Рабочий выпустил продукцию";
        }

        public override string ToString()
        {
            return $"Рабочий: {base.ToString()}";
        }
    }
}
