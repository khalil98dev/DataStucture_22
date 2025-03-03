using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Observabales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ObservableCollection<string> Names = new ObservableCollection<string>()
            {
                "khalil",
                "Anis",
                "Younes",
                "Adam"
            };




            Console.WriteLine("List beafore Notifications");
            foreach (string name in Names)
            {
                Console.WriteLine("\n" + name);
            }


            Names.CollectionChanged += Notifay_Item;



            Console.WriteLine("After Notify");
            foreach (string name in Names)
            {
                Console.WriteLine("\n" + name);
            }


            Names.Add("Mohamed");
            Names.Remove(Names.Last());    
            Names.Remove(Names.First());
            Names[1] = "koko";


            Names.Move(0, 1);



            Console.WriteLine("List After update"); 
            foreach (string name in Names)
            {
                Console.WriteLine("\n" +name);
            }
            
            
            
            Console.ReadLine();



            void Notifay_Item(object sender,System.Collections.Specialized.NotifyCollectionChangedEventArgs e)

            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        foreach (var item in e.NewItems)
                        {
                            Console.WriteLine($"Add Item : ({item})");
                        }

                        break;
                    case NotifyCollectionChangedAction.Remove:
                        foreach (var item in e.OldItems)
                        {
                            Console.WriteLine($"Remove Item : ({item})");
                        }

                        break;
                    case NotifyCollectionChangedAction.Replace:

                        foreach (var item in e.OldItems)
                        {
                            Console.Write($"Reset Item from {item}");
                        }

                        foreach (var item in e.NewItems)
                        {
                            Console.Write($"To Item  {item}");
                        }
                        break;
                    case NotifyCollectionChangedAction.Move:

                        foreach (var item in e.NewItems)
                        {
                            Console.WriteLine($"\nItem {item} moved from {e.OldStartingIndex} to {e.NewStartingIndex}");
                        }
                       




                        break;







                }
            }

        }
    }
}
