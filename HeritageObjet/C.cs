namespace Model
{
    public class C : A
    {


        public override string ToString()
        {
            return "Je suis malade avec un certificat!";
        }
        public string Oneday()
        {
            string[] SR = base.Oneday().Split(DateTime.Now.ToString());
            

            return SR[0] + "bof. Je n'y vais pas !";
            
        }
    }
}