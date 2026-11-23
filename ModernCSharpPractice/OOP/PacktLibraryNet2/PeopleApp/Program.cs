using Packt.Shared;




static void ShowMessage(string message)
{
    Console.WriteLine(message);
}




static void OnButtonClicked(string itemname,
    string batchno,
    NotificationHandler notification) { 


    notification($"Item {itemname} saved");
    notification($"Batch {batchno} not expire");
    notification($"Save Suceesfully");



}

OnButtonClicked("Soap", "B123", ShowMessage);



public delegate void NotificationHandler(string message);


