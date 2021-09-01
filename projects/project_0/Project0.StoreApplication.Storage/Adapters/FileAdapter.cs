using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public List<T> ReadFromFile<T>(string path) where T : class
    {
      // open file
      if (!File.Exists(path))
      {
        return null;
      }
      var file = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<T>));
      var result = xml.Deserialize(file) as List<T>;
      file.Close();
      return result;
    }

    public void WriteToFile<T>(string path, List<T> data) where T : class
    {

      // open file
      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<T>));

      xml.Serialize(file, data);
      file.Close();
    }
  }
}

