using System.Formats.Asn1;

namespace shuffle;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int rastgele;
        int k;
        System.Console.WriteLine("arrayin uzunlugunu girin");
        int alen = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[alen];
        System.Console.WriteLine("sayıların okunacağı dosyanın yolunu giriniz:");
        string okumayolu = Console.ReadLine();
        using (StreamReader reader = new StreamReader(okumayolu)){

            for(int i=0; i<a.Length; i++){


                a[i] = Convert.ToInt32(reader.ReadLine());

            }
        }

        

        for(int j=0; j<a.Length; j++){

            rastgele = random.Next(1,a.Length);
            while(j == rastgele){
                rastgele = random.Next(1,a.Length);
            }
            k = a[j];
            a[j] = a[rastgele];
            a[rastgele] = k;
        }
        System.Console.WriteLine("sayıların yazılcağı dosyanın yolunu girin");
        string yazmayolu = Console.ReadLine();
        using(StreamWriter writer = new StreamWriter(yazmayolu)){

            foreach (var item in a)
            {
                writer.WriteLine(item);
            }




        }

        

    }
}
