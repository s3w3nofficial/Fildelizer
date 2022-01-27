namespace Fildelizer;

public record CommonArributeValues
{
    public string? Name { get; init; }
    public string? DisplayName { get; init; }
    public string? Placeholder { get; init; }
    public int? MaxLength { get; init; }
    public int? MinLength { get; init; }
    public bool IsRequired { get; init; }
    public string? Pattern { get; set; }
}