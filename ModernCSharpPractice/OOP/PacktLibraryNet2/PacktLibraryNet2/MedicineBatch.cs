namespace Packt.Shared;

public partial class MedicineBatch
{
    public string BatchNumber { get; private set; } = string.Empty;

    // Partial method declaration
    partial void OnBatchNumberChanged(
        string oldBatchNumber,
        string newBatchNumber);

    public void ChangeBatchNumber(string newBatchNumber)
    {
     

        string oldBatchNumber = BatchNumber;
        BatchNumber = newBatchNumber;

        OnBatchNumberChanged(oldBatchNumber, newBatchNumber);
    }
}