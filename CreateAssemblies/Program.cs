using System.Xml.Serialization;

public class Program
{
    public string Property { get; set; }

    static void Main(string[] args)
    {
        var i = 0;
        do
        {
            new XmlSerializer(typeof(Program), new XmlRootAttribute(""));
            i++;
        } while (true);
    }
}
