using CompanyLibrary.Interfaces;

namespace CompanyLibrary
{
    public class Brigadier : Employee, IBrigadier
    {
        public override string Work()
        {
            return "Бригадир закупил материал";
        }

        public string CheckWorkers()
        {
            return "Бригадир выполнил проверку рабочих";
        }

        public override string ToString()
        {
            return $"Бригадир: {base.ToString()}";
        }
    }
}
