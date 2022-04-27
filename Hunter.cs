namespace RabbitHunter;

public class Hunter
{
    public static bool Hunt(Rabbit rabbit)
    {
        bool catched = false;

        for (int i = rabbit.StartField; catched == false && i <= rabbit.EndField; i++)
        {
            catched = rabbit.Hunt(i);
        }

        for (int i = rabbit.EndField; catched == false && i >= rabbit.StartField; i--)
        {
            catched = rabbit.Hunt(i);
        }

        return catched;
    }
}
