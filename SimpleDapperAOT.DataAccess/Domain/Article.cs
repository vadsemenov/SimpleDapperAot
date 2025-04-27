namespace SimpleDapperAOT.DataAccess.Domain;

public class Article
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime NewDate { get; set; }
}