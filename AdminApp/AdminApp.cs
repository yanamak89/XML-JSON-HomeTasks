using System;
using System.IO;
using System.Xml;

namespace AdminApp;

public class AdminApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Адмін програма: Налаштування параметрів для UserApp");

        Console.WriteLine("Введіть колір фону (наприклад: Red, Green, Blue):");
        string backgroundColor = Console.ReadLine();

        Console.WriteLine("Введіть розмір шрифту (наприклад: 12, 8 ...): ");
        string fontSize = Console.ReadLine();
        
        // Створення XML-конфігураційного файлу
        XmlDocument configDoc = new XmlDocument();

        XmlElement root = configDoc.CreateElement("Configuration");
        configDoc.AppendChild(root);

        XmlElement bgElement = configDoc.CreateElement("BackgroundColor"); 
        bgElement.InnerText = backgroundColor;
        root.AppendChild(bgElement);

        XmlElement fontElement = configDoc.CreateElement("FontSize");
        fontElement.InnerText = fontSize; 
        root.AppendChild(fontElement);
        
        // Збереження конфігураційного файлу
        string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "UserConfig.xml");
        Console.WriteLine($"Конфігурація збережена в {configPath}");
        configDoc.Save(configPath);
    }
}