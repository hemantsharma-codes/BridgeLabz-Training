namespace CustomFurtnitureManufacturing
{
    internal class CutResults
    {
        private int revenue;
        private int waste;

        // Set total revenue
        public void SetRevenue(int revenue)
        {
            this.revenue = revenue;
        }

        // Set leftover waste
        public void SetWaste(int waste)
        {
            this.waste = waste;
        }

        // Get total revenue
        public int GetRevenue()
        {
            return revenue;
        }

        // Get leftover waste
        public int GetWaste()
        {
            return waste;
        }

        // Display result clearly
        public void DisplayResult()
        {
            System.Console.WriteLine("Revenue Earned : " + revenue);
            System.Console.WriteLine("Waste Left     : " + waste + " ft");
        }
    }
}
