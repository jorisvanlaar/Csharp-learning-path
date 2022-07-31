

List<IComputerController> controllers = new List<IComputerController>();

Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();

controllers.Add(keyboard);
controllers.Add(gameController);

foreach (IComputerController controller in controllers)
{
    if (controller is GameController gc)
    {
        gc.BatteryLevel = 100;
    }
}

using (Mouse mouse = new Mouse())
{

}
