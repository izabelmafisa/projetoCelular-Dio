namespace Projetocelular-dio.Models
{
     public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {

        }
        public override void DownloadApp(string nomeApp)
        {
            Console.WriteLine($"Baixando o aplicativo '{nomeApp}' no Iphone.");
        }
    }
}