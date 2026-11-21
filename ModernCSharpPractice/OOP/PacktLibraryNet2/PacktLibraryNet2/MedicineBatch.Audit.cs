namespace Packt.Shared;

public partial class MedicineBatch
{
	// Partial method implementation
	partial void OnBatchNumberChanged(
		string oldBatchNumber,
		string newBatchNumber)
	{
		Console.WriteLine(
			$"Batch changed from '{oldBatchNumber}' " +
			$"to '{newBatchNumber}'.");
	}
}