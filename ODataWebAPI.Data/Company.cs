using System.Collections.Generic;

public class Company
{
    public int ID { get; set; }
    public string Name { get; set; }

    public virtual List<Employee> Employees { get; set; }

    public Company()
    {
        Employees = new List<Employee>();
    }
}