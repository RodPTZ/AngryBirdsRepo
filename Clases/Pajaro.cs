namespace AngryBirds;

public abstract class Pajaro
{
    public int Ira { get; set; }
    public virtual void Enojarse()
    {
        Ira += 1;
    }
    public abstract int calcularFuerza();
}

