namespace Packt.Shared;

public partial class Person
{
    public static decimal CostOfBatch(string batchNo)
    {
        if (string.IsNullOrWhiteSpace(batchNo))
        {
            throw new ArgumentException(
                "Batch number cannot be null or empty.",
                nameof(batchNo));
        }

        return LocalCostOfBatch(batchNo);

        static decimal LocalCostOfBatch(string currentBatchNo)
        {
            // Temporary sample calculation.
            return 99.0m;
        }
    }
}