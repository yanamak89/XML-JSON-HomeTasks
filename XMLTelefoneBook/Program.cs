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
        
        PrintXmlInfo(filePath);
    }
    private static void PrintXmlInfo(string filePath)
    {
        XmlDocument xmlDocument = new XmlDocument();
        try
        {
            xmlDocument.Load(filePath);
            XmlNode root = xmlDocument.DocumentElement;
            if (root != null)
            {
                PrintElement(root, 0);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка при заватнаженні XML-файлу: {ex.Message}");
        }
    }
    
    private static void AddContact(XmlDocument xmlDocument, XmlElement root, string name, string phoneNumber)
    {
        XmlElement contact = xmlDocument.CreateElement("Contact");
        contact.InnerText = name;
        contact.SetAttribute("TelephoneNumber", phoneNumber);
        root.AppendChild(contact);
    }
    private static void PrintElement(XmlNode node, int level)
    {
        string intent = new string(' ', level * 2);
        Console.WriteLine($"{intent}Тег : {node.Name}");
        if (node != null)
        {
            foreach (XmlAttribute attribute in node.Attributes)
            {
                Console.WriteLine($"{intent} Атрибут: {attribute.Name} = {attribute.Value}");
            }
        }

        if (!string.IsNullOrWhiteSpace(node.InnerText) && node.ChildNodes.Count == 1)
        {
            Console.WriteLine($"{intent} Текст: {node.InnerText.Trim()}");
        }

        foreach (XmlNode childNode in node.ChildNodes)
        {
            PrintElement(childNode, level + 1);
        }
    }
}