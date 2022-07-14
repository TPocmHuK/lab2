namespace lab3.Models;

public class LanguagesModel
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public long TypeId { get; set; }

    public LanguagesTypeModel LanguagesTypeModel { get; set; } = null!;
}