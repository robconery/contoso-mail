using System.Data;
using Contoso.Data;
using Contoso.Mail.Models;
using Dapper;
/// <summary>
/// This command deletes a contact and all associated data from the database. It uses a transaction to ensure that all related records are deleted together. If any part of the deletion process fails, the transaction is rolled back to maintain data integrity. The command returns a CommandResult indicating whether the operation was successful or if it encountered an error, along with any relevant messages. This ensures that the caller can handle the outcome appropriately, whether it needs to confirm the deletion to the user or log an error for troubleshooting. By encapsulating the deletion logic within a command, we promote separation of concerns and make our code more maintainable. The command can be easily reused in different parts of the application where contact deletion is
/// required, such as in an API endpoint, a background job, or a user interface action. This design also allows for better error handling and logging, as all the logic related to contact deletion is centralized within this command class. Additionally, using Dapper for database operations ensures that we have efficient and straightforward data access while maintaining control over our SQL queries. Overall, this command provides a robust and maintainable way to handle contact deletions in our application. It ensures that all related data is properly cleaned up, preventing orphaned records and maintaining the integrity of our database. By using transactions, we can guarantee that either all related records are deleted successfully or none are, which helps to avoid data inconsistencies. The CommandResult object allows us to communicate the outcome
///</summary>

namespace Contoso.Mail.Commands;

public class ContactDeleteCommand
{
  public Contact Contact { get; set; }
  public ContactDeleteCommand(Contact contact)
  {
    Contact = contact;
  }
  public CommandResult Execute(IDbConnection conn)
  {
    var tx = conn.BeginTransaction();

    try
    {
      conn.Execute("delete from tagged where contact_id=@id", new { id = Contact.ID }, tx);
      conn.Execute("delete from activity where contact_id=@id", new { id = Contact.ID }, tx);
      conn.Execute("delete from subscriptions where contact_id=@id", new { id = Contact.ID }, tx);
      conn.Delete<Contact>(Contact, tx);
      tx.Commit();
      return new CommandResult
      {
        Deleted = 1,
        Data = new
        {
          Success = true,
        }
      };
    }
    catch (Exception e)
    {
      tx.Rollback();
      return new CommandResult
      {
        Data = new
        {
          Success = false,
          Message = e.Message
        }
      };
    }
  }
}