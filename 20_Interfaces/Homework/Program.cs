using Homework;


Human human = new Human();
Animal animal = new Animal();

List<IRun> runners = new List<IRun>();
runners.Add(human);
runners.Add(animal);

foreach (IRun runner in runners)
{
    runner.StartRunning();
    runner.StopRunning();

    if (runner is Human h)
    {
        h.DisplayMaxHumanSpeed();
    }
    else if (runner is Animal a)
    {
        a.DisplayMaxAnimalSpeed();
    }
    else
    {
        Console.WriteLine("We don't know the max speed of aliens");
    }
}