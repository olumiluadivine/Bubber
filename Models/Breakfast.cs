namespace Bubber.Models;

public class BreakFast
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDatetime { get; }
    public DateTime EndDatetime { get; }
    public DateTime LastModifiedDatetime { get; }
    public List<string> Savory { get; }
    public List<string> Sweet { get; }
}
