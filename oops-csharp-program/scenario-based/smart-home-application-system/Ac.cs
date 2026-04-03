internal class Ac:Appliance,IControllable
{
    public Ac(string applianceName,bool applianceStatus) : base(applianceName, false) { }

    public void TurnOn()
    {
        if (!ApplianceStatus)
        {
            ApplianceStatus = true;
            Console.WriteLine("Ac is turned ON");
        }
        else
        {
            Console.WriteLine("Ac is already turned ON");
        }
    }
    public void TurnOff()
    {
        if (ApplianceStatus)
        {
            ApplianceStatus = false;
            Console.WriteLine("Ac is turned OFF");
        }
        else
        {
            Console.WriteLine("Ac is already turned OFF");
        }
    }

    public override void DisplayMenu()
    {
        base.DisplayMenu();
    }
}
