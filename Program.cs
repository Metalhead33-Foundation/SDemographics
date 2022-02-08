using System.IO;
using Newtonsoft.Json;
using WoDDemographics;
using System.Xml.Serialization;
class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
        Console.WriteLine("Hello, World!");
        // Basic shit
        /*Welcome unified = WodDemogr.QueryFromJson("/home/metalhead33/MEGA/WoD/woddemogr");
        using(StreamWriter writer = new StreamWriter("unified.xml")) {
            XmlSerializer serializer = new XmlSerializer(typeof(Welcome));
            serializer.Serialize(writer,unified);
        }*/
        using(StreamReader reader = new StreamReader("unified.xml")) {
            XmlSerializer serializer = new XmlSerializer(typeof(Welcome));
            Welcome unified = (Welcome)serializer.Deserialize(reader);
            WodDemogr.saveSeparate(unified,"/tmp",Newtonsoft.Json.Formatting.Indented);
        }
    }
}
