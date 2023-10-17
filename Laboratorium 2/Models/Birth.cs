namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? Date { get; set; }

        public bool IsValid()
        {         
            if(CalculateDate() && Name is not null && Date.Value < DateTime.Now) 
            { 
                return true; 
            }
            return false;
        }

        private bool CalculateDate()
        {
            if (Date is not null)
            {
                Age = DateTime.Now.Year - Date.Value.Year;
                return true;
            }  
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            string result = $"Cześć {Name}, masz {Age} lat(a)";
            return result;
        }
    }
}
