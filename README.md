# XML-JSON-HomeTasks

This project includes several tasks to work with XML files, manipulate data, and create programs that store and retrieve configuration information.

---

## Task (XMLReader)

**Description**: Create a program that displays all information from a specified `.xml` file.

### Instructions
1. Write a C# program that loads the `.xml` file using `XmlDocument`.
2. Traverse the entire XML structure and print each element, attribute, and text content to the console.

---

## Task (TelephoneBookReader)

**Description**: From the file `TelephoneBook.xml` (which should be created in an additional task), display only the phone numbers on the screen.

### Instructions
1. Use `XmlDocument` or `XDocument` to load `TelephoneBook.xml`.
2. Iterate over the `<Contact>` tags and extract the `TelephoneNumber` attribute.
3. Print only the phone numbers.

---

## Task (AdminAndUserApp)

**Description**: Using the examples discussed in the lesson, create an admin program that saves configuration data in a special file or registry. Then, create a user program, the appearance of which can be controlled by the admin program.

### Instructions
1. Create an admin program (`AdminApp`) that asks the user to input configuration values (e.g., background color, font size).
2. Save these values in an XML file, `UserConfig.xml`.
3. Create a user program (`UserApp`) that reads `UserConfig.xml` and applies the specified appearance settings to its interface.

---

## Task (XMLTelefoneBook)

**Description**: Create an XML file that meets the following requirements:

- **File name**: `TelephoneBook.xml`
- **Root element**: `<MyContacts>`
- **Child elements**: `<Contact>` tags, each containing a contact's name as text and an attribute `TelephoneNumber` with the phone number.

### Instructions
1. Write a C# program that creates an XML structure for the telephone book.
2. Use `XmlDocument` to create the root element and populate it with `<Contact>` elements.
3. Save the XML file as `TelephoneBook.xml`.

### Example XML Structure

```xml
<MyContacts>
    <Contact TelephoneNumber="123-456-7890">John Doe</Contact>
    <Contact TelephoneNumber="987-654-3210">Jane Smith</Contact>
    <Contact TelephoneNumber="555-123-4567">Bob Johnson</Contact>
</MyContacts>
