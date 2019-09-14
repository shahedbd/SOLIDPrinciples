namespace SOLID.SingleResponsibilityPrinciple.WithGenericSRP
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
