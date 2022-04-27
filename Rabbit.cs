namespace RabbitHunter;

public class Rabbit
{
    private int startField;
    private int endField;

    public int StartField { get => startField; }
    public int EndField { get => endField; }

    private int position;
    private Random random;

    public Rabbit(int startField = 1, int endField = 100)
    {
        this.startField = startField;
        this.endField = endField;

        this.random = new Random();
        this.position = this.random.Next(startField, endField + 1);
    }

    public bool Hunt(int position)
    {
        bool catched = false;

        if (position == this.position)
        {
            catched = true;
        }
        else
        {
            Move();
        }

        return catched;
    }

    private void Move()
    {
        bool forward = (random.Next(2) == 1);
        bool backward = !forward;

        if (forward)
        {
            this.position += 1;
        }

        if (backward)
        {
            this.position -= 1;
        }

        if (this.position < this.startField)
        {
            this.position = this.startField + 1;
        }

        if (this.position > this.endField)
        {
            this.position = this.endField - 1;
        }
    }
}
