namespace Anonymous_Downsite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of sites: ");
            int sitesCount = int.Parse(Console.ReadLine());
            Console.Write("Enter security key: ");
            int key = int.Parse(Console.ReadLine());

            decimal totalLoss = 0m;
            List<string> sitesNames = new List<string>();

            for (int i = 0; i < sitesCount; i++)
            {
                Console.Write("Enter site and its info: ");
                string[] siteInfo = Console.ReadLine().Split(' ');
                string siteName = siteInfo[0];
                decimal siteVisits = decimal.Parse(siteInfo[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(siteInfo[2]);

                totalLoss += siteVisits * siteCommercialPricePerVisit;
                sitesNames.Add(siteName);
            }
            
            for (int i = 0; i < sitesCount; i++)
            {
                Console.WriteLine(sitesNames[i]);
            }

            Console.WriteLine("Total Loss: {0:F20}", totalLoss);
            Console.WriteLine("Security Token: {0}", Math.Pow(key, sitesCount));

        }
    }
}