namespace Dentique.Models;

public class Interaction
{
public int Id { get; set;}
public int? ClientId { get; set; }
public int? UserId { get; set; }
public string Name { get; set; } = string.Empty;
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
public List<User> Users { get; set; } = new(); //list of Users that has this Interaction. 
public List<Client> Clients { get; set; } = new(); //list of Clients that has this Interaction. 



}