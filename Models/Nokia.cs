namespace DesafioPOO.Models
{
    //  Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }


        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} através da play store...");
            Console.WriteLine($"{nomeApp} instalado com sucesso!!!");
        }
    }
}