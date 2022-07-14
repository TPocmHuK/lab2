namespace lab3.Models;

public class LanguagesTypeModel
{
    public long Id { get; set; }
    public string Type { get; set; } = string.Empty;

    public List<LanguagesModel> LanguagesModels { get; set; } = new();
}