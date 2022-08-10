using Homework;


IMobile mobileAnimal = new Monkey();

if (mobileAnimal is Monkey monkey)
{
    monkey.Species = "Ape";
    monkey.Move();
    monkey.EatBanana();
}
