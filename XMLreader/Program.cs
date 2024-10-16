using System;
using System.Xml;

class Program
{
    public static void Main()
    {
        string filePath = "/Users/yanamakogon/RiderProjects/XML-JSON-HomeTasks/XMLreader/example.xml";
        PrintXmlInfo(filePath);

    }

    static void PrintXmlInfo(string filePath)
    {
        XmlDocument xmlDoc = new XmlDocument();

        try
        {
            xmlDoc.Load(filePath);
            XmlNode root = xmlDoc.DocumentElement;
            if (root != null)
            {
                PrintElement(root, 0);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при заватнаженні XML-файлу: {ex.Message}");
        }
    }

    static void PrintElement(XmlNode node, int level)
    {
        string indent = new string(' ', level * 2);
        Console.WriteLine($"{indent}Ter : {node.Name}");
        
        // Виводимо атрибути, якщо вони є
        if(node.Attributes != null)
        {
            foreach (XmlAttribute attribute in node.Attributes)
            {
                Console.WriteLine($"{indent} Атрибут: {attribute.Name} = {attribute.Value}");
            }
        }
        
        // Виводимо текстовий вміст, якщо він є
        if (!string.IsNullOrWhiteSpace(node.InnerText) && node.ChildNodes.Count == 1)
        {
            Console.WriteLine($"{indent} Текст: {node.InnerText.Trim()}");
        }
        
        // Рекурсивно обходимо дочірні вузли
        foreach (XmlNode childNode in node.ChildNodes)
        {
            PrintElement(childNode, level + 1);
        }
    }
}
