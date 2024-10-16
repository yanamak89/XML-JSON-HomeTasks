using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "/Users/yanamakogon/RiderProjects/XML-JSON-HomeTasks/2.TelephoneBookReader/TelephoneBook.xml";
        PrintPhoneNumber(filePath);

    }
    public static void PrintPhoneNumber(string filePath)
    {
        XmlDocument xmlDocument = new XmlDocument();

        try
        {
            xmlDocument.Load(filePath);
            
            // Знаходимо всі елементи <PhoneNumber>
            XmlNodeList phoneNodes = xmlDocument.GetElementsByTagName("PhoneNumber");
            Console.WriteLine("Номери телефонів: ");
            foreach (XmlNode phoneNode in phoneNodes)
            {
                Console.WriteLine(phoneNode.InnerText.Trim());
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при читанні XML-файлу: {ex.Message}");
           
        }
    }
}

