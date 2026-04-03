internal class Light : Appliance, IControllable
{
    public Light(string applianceName, bool applianceStatus)
        : base(applianceName, false) { }


    public void TurnOn()
    {
        if (!ApplianceStatus)
        {
            ApplianceStatus = true;
            Console.WriteLine("Light is turned ON");
        }
        else
        {
            Console.WriteLine("Light is already ON");

        }
    }
    public void TurnOff()
    {
        if (ApplianceStatus)
        {
            ApplianceStatus = false;
            Console.WriteLine("Light is turned OFF");
        }
        else
        {
            Console.WriteLine("Light is already turned OFF");
        }
    }
    public override void DisplayMenu()
    {
        base.DisplayMenu();
    }
}
