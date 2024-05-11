namespace NET105_Lab1.Models
{
    public class department
    {
       
            public int departmentId { get; set; }
            public string departmentName { get; set; }
            //1-nhiều
            public ICollection<employee> employees { get; }
        
    }
}
