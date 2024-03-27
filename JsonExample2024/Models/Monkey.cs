using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{

    public class MonkeyList
    {
        public List<Monkey> monkeys { get; set; }
        public MonkeyList()
        {
            monkeys = new List<Monkey>();
        }
        public void FillList()
        {
            string text = File.ReadAllText(@"C:\Users\User\Source\Repos\HavivSivan\JsonExample2024\JsonExample2024\monkeydata.json");
            List<Monkey> monkes=JsonSerializer.Deserialize<List<Monkey>>(text);
            foreach (Monkey monkey in monkes)
            {
                monkeys.Add(monkey);
            }
        }
    }
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }


}
