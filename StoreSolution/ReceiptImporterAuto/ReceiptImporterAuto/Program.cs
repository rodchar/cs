using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using LogicSpinner;

namespace ReceiptImporterAuto
{
    class Program
    {
        const string INPUT_FILE = @"c:\temp\feed.txt";
        const string OUTPUT_FILE = @"c:\temp\read.txt";
        const string CONDITION_STRING = "Thanks for shopping with us!";
        const string DATE_PATTERN = @"(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?";
        const string PURCHASE_ITEM_PATTERN = @"([a-z\s]+)(\d*\.\d{2})";

        static void Main(string[] args)
        {
            FileStream readLogs;
            using (readLogs = new FileStream(OUTPUT_FILE, FileMode.OpenOrCreate)) { };
            int readCount = File.ReadLines(OUTPUT_FILE).Count();
            using (readLogs = new FileStream(OUTPUT_FILE, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(readLogs))
            {
                IEnumerable<string> lines = File.ReadLines(INPUT_FILE).Skip(readCount);
                List<ReceiptItem> receiptItems = new List<ReceiptItem>();
                int newReceiptId = 0;
                
                foreach (string line in lines)
                {
                    //Search for business rule pattern
                    var dateMatch = Regex.Match(line, DATE_PATTERN, RegexOptions.IgnoreCase);
                    var purchaseItemMatch = Regex.Match(line, PURCHASE_ITEM_PATTERN, RegexOptions.IgnoreCase);


                    //if line contains a date and time (regex)
                    if (dateMatch.Success)
                    {
                        Console.WriteLine(dateMatch.Value);
                        
                        // create a Receipt object
                        DateTime d = default(DateTime);
                        DateTime.TryParse(dateMatch.Value,out d);
                        if (d != DateTime.MinValue)
                        {
                            newReceiptId = ReceiptBLL.UpdateReceipt(new Receipt() { Date = d });
                            receiptItems = new List<ReceiptItem>();
                        }
                        else
                        {
                            continue; //something weird might have happened 
                        }
                    }

                    // start processing line items (regex)
                    if (purchaseItemMatch.Success)
                    {
                        Console.WriteLine("{0}:{1}", purchaseItemMatch.Groups[1].Value, purchaseItemMatch.Groups[2].Value);

                        // create a list<ReceiptItem>
                        ReceiptItem item = new ReceiptItem();
                        item.Name = purchaseItemMatch.Groups[1].Value;
                        decimal cost = 0M;
                        decimal.TryParse(purchaseItemMatch.Groups[2].Value, out cost);
                        item.Cost = cost;
                        item.ProductName = ReceiptBLL.UpdateReceiptItem(newReceiptId, item);
                        receiptItems.Add(item);
                    }

                    //process as line read. 
                    writer.WriteLine(line);
                }
            }
        }
    }
}