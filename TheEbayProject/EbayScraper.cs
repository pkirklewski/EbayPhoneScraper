using System;


namespace TheEbayProject
{
    public class EbayScraper
    {
        System.Net.WebClient client = new System.Net.WebClient();
        String htmlCode = client.DownloadString("https://www.ebay.co.uk/b/Samsung-Galaxy-S8/9355/bn_75787856?LH_ItemCondition=2000");
        
    }
}
