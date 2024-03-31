class Bus
{
    public string Modelo { get; set; }
    public int MaxCapacidad { get; set; }
    public int Pasajeros { get; set; }
    public double Precio { get; set; }

    public Bus(string modelo, int maxCapacidad, double precio)
    {
        Modelo = modelo;
        MaxCapacidad = maxCapacidad;
        Precio = precio;
        Pasajeros = 0;
    }

    public virtual void VenderAsiento(int asientosComprados)
    {
        Pasajeros += asientosComprados;
        double total = asientosComprados * Precio;
        Console.WriteLine($"Auto Bus {Modelo} {asientosComprados} Pasajeros Ventas {total} quedan {MaxCapacidad - Pasajeros} asientos disponibles");
    }
}

class BusPlatinum : Bus
{
    public BusPlatinum() : base("Platinum", 22, 1000)
    {
    }
}

class BusGold : Bus
{
    public BusGold() : base("Gold", 15, 1333.33)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        BusPlatinum busPlatinum = new BusPlatinum();
        BusGold busGold = new BusGold();

        busPlatinum.VenderAsiento(5);
        busGold.VenderAsiento(3);
    }
}
