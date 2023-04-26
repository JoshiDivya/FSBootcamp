class Car
{
    public string model {get;set;} 
    public string make {get;set;} 
    public int currentSpeed {get; private set;} 
    public bool engineRunning {get; private set;} 

    private void startEngine()
    {
       engineRunning = true;
    }
    private void stopEngine()
    {
        engineRunning = false;
    }
    private void accelerate()
    {
       currentSpeed += 10;
       if(currentSpeed> 200)
       currentSpeed = 200;

    }
    private void decelerate()
    {
       currentSpeed -= 10;      
    }

    // Car car = new Car();
    // car.make = "Volvo";
    //    car.currentSpeed= 100;
    //    car.model = "Volvo cc";
    //    car.engineRunning = true;



}
