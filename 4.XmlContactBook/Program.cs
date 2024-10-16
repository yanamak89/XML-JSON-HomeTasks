using System;
using System.IO;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        string filePath =
            Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.UserProfile), "TelephoneBook.xml");

        XmlDocument xmlDocument = new XmlDocument();

        XmlElement root = xmlDocument.CreateElement("MyContacts");
        xmlDocument.AppendChild(root);

        AddContact(xmlDocument, root, "John Doe", "123-456-7890");
        AddContact(xmlDocument, root, "Jane Smith", "987-654-3210");
        AddContact(xmlDocument, root, "Bob Johnson", "555-123-4567");
        
        xmlDocument.Save(filePath);
        Console.WriteLine($"Файл {filePath} створено успішно.");
    }

    private static void AddContact(XmlDocument xmlDocument, XmlElement root, string name, string phoneNumber)
    {
        XmlElement contact = xmlDocument.CreateElement("Contact");
        contact.InnerText = name;
        contact.SetAttribute("TelephoneNumber", phoneNumber);
        root.AppendChild(contact);
    }
}