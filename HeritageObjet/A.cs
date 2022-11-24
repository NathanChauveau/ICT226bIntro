namespace Model
{
    public class A
    {


        public override string ToString()
        {
            return "Coucou je suis A";
        }

        public string Oneday()
        {
            return "Les portes ouvertes du CPNV sont le : " + DateTime.Now.ToString();
        }


    }
}