namespace Soltree.Api.Data.Dtos.Symptom
{
    public record SymptomUpdateRequest(Guid Id, string Name, Guid SymptomCategoryId);
}
