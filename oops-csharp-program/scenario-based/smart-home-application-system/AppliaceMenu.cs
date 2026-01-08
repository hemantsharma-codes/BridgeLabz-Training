sealed class ApplianceMenu
{
    private IControllable device;
    public static Appliance[] appliances = new Appliance[] {
        new Light("Light", false),
        new Fan("Fan",false),
        new Ac("Ac",false)
    };

    public void Choice()
    {
        Console.WriteLine("\n=========Smart Home Automation System===========");

        Console.WriteLine("1. Turn on Light");
        Console.WriteLine("2. Turn off Light");
        Console.WriteLine("3. Display details of Light");
        Console.WriteLine("4. Turn on Fan");
        Console.WriteLine("5. Turn off Fan");
        Console.WriteLine("6. Display details of Fan");
        Console.WriteLine("7. Turn on Ac");
        Console.WriteLine("8. Turn off Ac");
        Console.WriteLine("9. Display details of Ac");
        Console.WriteLine("10. Exit");

        while (true)
        {
            Console.WriteLine("Please enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    device = (IControllable)appliances[0];
                    device.TurnOn();
                    break;
                case 2:
                    device = (IControllable)appliances[0];
                    device.TurnOff();
                    break;
                case 3:
                    appliances[0].DisplayMenu();
                    break;
                case 4:
                    device = (IControllable)appliances[1];
                    device.TurnOn();
                    break;
                case 5:
                    device = (IControllable)appliances[1];
                    device.TurnOff();
                    break;
                case 6:
                    appliances[1].DisplayMenu();
                    break;
                case 7:
                    device = (IControllable)appliances[2];
                    device.TurnOn();
                    break;
                case 8:
                    device = (IControllable)appliances[2];
                    device.TurnOff();
                    break;
                case 9:
                    appliances[2].DisplayMenu();
                    break;
                case 10:
                    Console.WriteLine("Exiting....");
                    return;

            }

        }
    }
}
