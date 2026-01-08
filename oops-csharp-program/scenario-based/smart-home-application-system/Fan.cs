internal class Fan:Appliance,IControllable
{
    public Fan(string applianceName,bool applianceStatus) :
        base(applianceName, false) { }

    public void TurnOn()
    {
        if (!ApplianceStatus)
        {
            ApplianceStatus = true;
            Console.WriteLine("Fan is turned ON");
        }
        else
        {
            Console.WriteLine("Fan is already turned ON");
        }
    }
    public void TurnOff()
    {
        if (ApplianceStatus)
        {
            ApplianceStatus = false;
            Console.WriteLine("Fan is turned OFF");
        }
        else
        {
            Console.WriteLine("Fan is already turned OFF");
        }
    }
    public override void DisplayMenu()
    {
        base.DisplayMenu();
    }
}
