namespace EssentialTraining
{
    public class FlowControl2
    {
        public string LetraSegunCalificacion ( int nota)
        {
            if (nota > 9)
            {
                return "A+";
            }
            else if (nota >= 7 && nota <= 9)
            {
                return "AR";
            }
            else if (nota < 7 && nota >=4)
            {
                return "A-";
            }
            else
            {
                return "D";
            }
        }
    }
}
