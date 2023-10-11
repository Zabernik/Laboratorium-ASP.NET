namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public DateTime Real { get; set; }

        public bool IsValid()
        {
            CalculateDate();
            if(Name is not null && Date > DateTime.Now) 
            { 
                return true; 
            }
            return false;
        }

        private void CalculateDate()
        {
            Age = DateTime.Now.Year - Date.Year;            
        }

        public string ToString()
        {
            CalculateDate();
            string result = $"Cześć {Name}, masz {Age} lat(a)";
            return result;
        }
    }
}
