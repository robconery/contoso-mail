namespace Contoso.Data;
public class CommandResult
{
  public required dynamic Data { get; set; }
  public int Inserted { get; set; } = 0;
  public int Updated { get; set; } = 0;
  public int Deleted { get; set; } = 0;

}