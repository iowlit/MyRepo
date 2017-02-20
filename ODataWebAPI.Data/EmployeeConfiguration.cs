using System.Data.Entity.ModelConfiguration;

class EmployeeConfiguration : EntityTypeConfiguration<Employee>
{
    public EmployeeConfiguration()
    {
        ToTable("Employees");
        Property(e => e.CompanyID).IsRequired();
        Property(e => e.AddressID).IsRequired();
    }
}