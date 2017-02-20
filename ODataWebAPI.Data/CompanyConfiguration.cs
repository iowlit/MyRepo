using System.Data.Entity.ModelConfiguration;

public class CompanyConfiguration : EntityTypeConfiguration<Company>
{
    public CompanyConfiguration()
    {
        ToTable("Companies");
    }
}