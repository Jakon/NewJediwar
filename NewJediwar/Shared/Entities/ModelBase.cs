namespace NewJediwar.Shared.Entities;

public interface IModelBase
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
