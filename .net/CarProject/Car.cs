class Car
{
    public string model { get; set; }
    public string make { get; set; }
    public int currentSpeed { get; private set; }
    public bool engineRunning { get; private set; }

    public void startEngine()
    {
        engineRunning = true;
    }
    public void stopEngine()
    {
        engineRunning = false;
    }
    public void accelerate()
    {

        if (!engineRunning)
        {
            throw new InvalidOperationException("acceletor not possible because of startEngine is not called");
        }

        const int maxSpeed = 200;
        currentSpeed += 10;

        if (currentSpeed > maxSpeed)
            currentSpeed = maxSpeed;

    }
    public void decelerate()
    {
        currentSpeed -= 10;

        if (currentSpeed < 0)
        {
            currentSpeed = 0;
        }
    }




}
