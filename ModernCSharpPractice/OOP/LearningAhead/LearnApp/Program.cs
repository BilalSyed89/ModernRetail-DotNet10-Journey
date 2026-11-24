
Vehicle car=new Car();

car.ElectricEngine = "Electric Motor";

car.Start();

if (car is Car c)
{
    c.OpenTrunk();
}

Vehicle sc = new Scooter();

sc.CombustionEngine = "Gasoline Engine";

sc.Start();

if (sc is Scooter scooter)
{
    scooter.KickStart();
}









