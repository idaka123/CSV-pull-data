using System;
using CsvHelper;    
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper.Configuration.Attributes;


namespace csvPullData {

    class Program
    {
        static void Main(string[] args)
        {
            
            using(var streamReader = new StreamReader(@"C:\Users\canh.pham\Documents\Code\Okendo\CSV\Archive\reviews-export-swimoutlet.com.csv")) {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture)) {

                    var records = csvReader.GetRecords<ReviewModel>().ToList();
                    foreach(var record in records) {
                        Console.WriteLine(record.ReplyIsPublic);
                    }
                }
            }

            // string csvFilePath = @"C:\Users\canh.pham\Documents\Code\Okendo\CSV\Archive\reviews-export-swimoutlet.com.csv";

           
        }


    }
    
}


public class ReviewModel
{
   [Name("hash")]
   public string Hash { get; set; }

   [Name("body")]
   public string Body { get; set; }

   [Name("countryCode")]
   public string CountryCode { get; set; }

   [Name("dateCreated")]
   public DateTime DateCreated { get; set; }

   [Name("email")]
   public string Email { get; set; }

   [Name("handle")]
   public string Handle { get; set; }

   [Name("imageCount")]
   public int ImageCount { get; set; }

   [Name("imageUrls")]
   public string ImageUrls { get; set; }

   [Name("isApproved")]
   public bool? IsApproved { get; set; }

   [Name("isRecommended")]
   public bool? IsRecommended { get; set; }

   [Name("isVerifiedBuyer")]
   public bool? IsVerifiedBuyer { get; set; }

   [Name("name")]
   public string Name { get; set; }

   [Name("productId")]
   public string ProductId { get; set; }

   [Name("productName")]
   public string ProductName { get; set; }

   [Name("rating")]
   public int Rating { get; set; }

   [Name("rejectedImageUrls")]
   public string RejectedImageUrls { get; set; }

   [Name("reply")]
   public string Reply { get; set; }

   [Name("replyDateCreated")]
   public DateTime? ReplyDateCreated { get; set; }

   [Name("replyIsPublic")]
   public bool? ReplyIsPublic { get; set; }

   [Name("sku")]
   public string Sku { get; set; }

   [Name("source")]
   public string Source { get; set; }

   [Name("status")]
   public string Status { get; set; }

   [Name("syndicated")]
   public string Syndicated { get; set; }

   [Name("title")]
   public string Title { get; set; }

   [Name("variantId")]
   public string VariantId { get; set; }

   [Name("videoCount")]
   public int? VideoCount { get; set; }

   [Name("videoUrls")]
   public string VideoUrls { get; set; }

   [Name("Fit/Sizing")]
   public double? FitSizing { get; set; }

   [Name("Primary Activity Uses")]
   public string PrimaryActivityUses { get; set; }

   [Name("Body Type")]
   public string BodyType { get; set; }

}
