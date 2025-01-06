using System.Text.Json;

namespace Assignment10_1_
{

    ///<summary>
    /// Assignment 10.1
    /// Serialize and Deserialize a Student object using JSON, XML, and Binary formats.
    ///</summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 10.1");
            Console.WriteLine("===============\n");
            
            // Create a Student object instance
            Student student = new Student { Id = 1, Name = "Joe Snuffy", GPA = 3.4 };

            //JSON Serialization
            JsonSerializeAndDeserialize(student);

            //XML Serialization


            //Binary Serialization
        }

        /// <summary>
        /// Demonstrates JSON serialization and deserialization of a Student object.
        /// </summary>
        static void JsonSerializeAndDeserialize(Student student)
        {
            Console.WriteLine("JSON Serialization & Deserialization:");

            // Serialize to JSON
            string jsonString = JsonSerializer.Serialize(student);
            Console.WriteLine($"Serialized JSON: {jsonString}");

            // Deserialize from JSON
            Student? deserializedStudent = JsonSerializer.Deserialize<Student>(jsonString);
            Console.WriteLine($"Deserialized JSON: {deserializedStudent}\n");
        }

    }
}
