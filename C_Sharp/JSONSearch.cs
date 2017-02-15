using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject obj = JObject.Parse(@"{
               'root' : { 
                    'CPU' : 'Intel',
                    'Drives' : {
                        'Features' : 'Warranty',
                        'Manufacturers'  : 'Western Digital'
                    }, 
                    'Screen' : 'Dell'
                }   
            }");

            JToken jToken = obj as JToken;

            bool output = BFS(jToken, "Manufacturers");
            Console.WriteLine(output);
            Console.Read();
        }

        public static bool BFS(JToken root, string input)
        {
            Queue<JToken> list = new Queue<JToken>();
            list.Enqueue(root.First);

            JToken node;
            // Run loop till there are values in queue
            while (list.Count > 0)
            {
                node = list.Dequeue();
                JEnumerable<JToken> children = node.Children();

                foreach (JToken child in children.Children<JToken>())
                {
                    list.Enqueue(child);
                }

                JProperty jProp = node as JProperty;

                if (jProp.Name.ToString().Equals(input))
                {
                    return true;
                }
            }
            return false;
        }       
    }

    public class first
    {
        public virtual bool doSomething()
        {
            return false;
        }
        public void doSomethingChild()
        {
            Console.WriteLine("Inside Parent");
        }
    }

    class child : first
    {

        public override bool doSomething()
        {
            return true;
        }
        public void doSomethingChildValue()
        {
            Console.WriteLine("Inside Child");
        }
    }

}
