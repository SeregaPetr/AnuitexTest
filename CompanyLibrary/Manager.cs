using CompanyLibrary.Interfaces;

namespace CompanyLibrary
{
    public class Manager : Employee, IManager
    {
        public override string Work()
        {
            return "Менеджер собрал заказы";
        }

        public string ToGiveTask()
        {
            return "Менеджер выдал задание";
        }

        public override string ToString()
        {
            return $"Менеджер: {base.ToString()}";
        }
    }
}
