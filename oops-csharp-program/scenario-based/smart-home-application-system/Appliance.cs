 internal class Appliance
 {
     protected string ApplianceName;
     protected bool ApplianceStatus;

     public string GetApplianceName()
     {
         return this.ApplianceName;
     }
     public bool GetApplianceStatus()
     {
         return this.ApplianceStatus;
     }
     public Appliance(string applianceName,bool applianceStatus)
     {
         this.ApplianceName = applianceName;
         this.ApplianceStatus = applianceStatus;
     }
     public virtual void DisplayMenu()
     {
         Console.WriteLine($"Appliance: {ApplianceName}");
         Console.WriteLine($"Status   : {(ApplianceStatus ? "ON" : "OFF")}");
     }
 }
