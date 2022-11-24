
namespace Model
{
    public class B : A
    {
        

        public override string ToString()
        {
            return base.ToString() + ", et B";
        }

        public string Oneday()
        {
            return base.Oneday() + " Heu non, dans 2 jours";
        }
    }
}