Console.Clear();

string movendo, mover;

Console.WriteLine("--- Fluxograma Da Engenharia ---");

Console.Write("O objeto esta se movendo (S/N)? ");
movendo = Console.ReadLine()!.ToUpper();

if (movendo == "N")
{
    Console.Write("Deveria (S/N)? ");
    mover = Console.ReadLine()!.ToUpper();
    
    if (mover == "S")
    {
        Console.Write("Use WD-40.");
        Environment.Exit(-1);
    }
}
if (movendo == "S")
{
    Console.Write("Deveria (S/N)? ");
    mover = Console.ReadLine()!.ToUpper();
    
    if (mover == "N")
    {
        Console.Write("Use Silver Tape.");
        Environment.Exit(-1);
    }
}

 Console.WriteLine("Esta tudo certo");