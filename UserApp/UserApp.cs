using System;
using System.IO;
using System.Xml;

namespace UserApp;

public class UserApp
{
    public static void Main(string[] args)
    {
        string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "UserConfig.xml");
        string backgroundColor = "Black";  // За замовчуванням
        int fontSize = 12;  // За замовчуванням

        if (System.IO.File.Exists(configPath))
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(configPath);
            
            // Отримуємо колір фону
            XmlNode bgNode = configDoc.SelectSingleNode("//BackgroundColor");
            if (bgNode != null)
            {
                backgroundColor = bgNode.InnerText;
            }
            
            // Отримуємо розмір шрифту
            XmlNode fontNode = configDoc.SelectSingleNode("//FontSize");
            if (fontNode != null && int.TryParse(fontNode.InnerText, out int size))
            {
                fontSize = size;
            }
        }
        else
        {
            Console.WriteLine("Конфігураційний файл не знайдено. Використовуються стандартні налаштування.");
        }
        
        // Виведення повідомлення з імітацією застосування налаштувань
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundColor, true);
        Console.WriteLine($"Налаштований інтерфейс UserApp:");
        Console.WriteLine($"Колір фону: {backgroundColor}");
        Console.WriteLine($"Розмір шрифту: {fontSize}");
        
        Console.ResetColor();
    }
}