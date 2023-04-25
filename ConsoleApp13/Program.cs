//class Program
//{
//    static void Main(string[] args)
//    {
//        var npc = new NPC();
//        npc.Name = "jemali";
//        npc.Health = 70;
//        npc.AttackPwr = 20;
//        npc.Attack();

//        var maugli = new PlayerCharacter();
//        maugli.Name = "pavle";
//        maugli.Health = 200;
//        maugli.AttackPwr = 50;
//        maugli.Attack();
//        maugli.Boost(20);
//    }
//}


//public interface ICharacter
//{
//    string Name { get; set; }
//    double Health { get; set; }
//    double AttackPwr { get; set; }
//    void Move();
//    void ResetPwr();
//    void Attack();
//}

//public class PlayerCharacter : ICharacter
//{
//    public string Name { get; set; }
//    public double Health { get; set; }
//    public double AttackPwr { get; set; }
//    public void Move()
//    {
//        //sait wavides
//        Console.WriteLine("Modzraobs :" + Name);
//    }
//    public void Attack()
//    {
//        Console.WriteLine("Attacking :" + Name);
//        Health -= AttackPwr;
//    }
//    public void ResetPwr()
//    {
//        Health = 100;
//    }
//    public void Boost(double boost)
//    {
//        Health += 100;
//        Health -= boost;
//    }
//}

//public class NPC : ICharacter
//{
//    public string Name { get; set; }
//    public double Health { get; set; }
//    public double AttackPwr { get; set; }
//    public void Move()
//    {
//        //sait wavides
//        Console.WriteLine("Modzraobs :" + Name);
//    }
//    public void Attack()
//    {
//        Console.WriteLine("Attacking :" + Name);
//        Health -= AttackPwr;
//    }
//    public void ResetPwr()
//    {
//        Health = 50;
//    }
//}



class Program
{
    static void Main(string[] args)
    {
        var cardrive = new Car();
        cardrive.Speed = 50;

        var motorcycledrive = new Motorcycle();
        motorcycledrive.Speed = 70;

        cardrive.Drive();

        motorcycledrive.Drive();
    }
}

public interface IVehicle
{
    int NumWheels { get;  }
    int NumDoors { get;  }
    int Speed { get; set; }
    void Drive();
}

public class Car : IVehicle
{
    public int NumWheels { get { return 4; } }
    public int NumDoors { get { return 4; } }
    public int Speed { get; set; }
    public void Drive()
    {
        Console.WriteLine("Driving at:" + " " + " " + Speed +" "+"|"+ "Amount of doors:" + " " + NumDoors+" "+"|"+"Amount of Wheels:" + " "+ NumWheels);
    }
}

public class Motorcycle : IVehicle
{
    public int NumWheels { get { return 2; } }
    public int NumDoors { get { return 0; } }
    public int Speed { get; set; }
    public void Drive()
    {
        Console.WriteLine("Driving at:" + " " + " " + Speed + " " + "|" + "Amount of doors:" + " " + NumDoors + " " + "|" + "Amount of Wheels:" + " " + NumWheels);
    }
}