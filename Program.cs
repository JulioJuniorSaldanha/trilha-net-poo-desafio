using DesafioPOO.Models;


Nokia nokia= new Nokia("(99)99999-9999","K-Muitos","000000-00-000000-0", 6);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("subway surfers");

Console.WriteLine();

Iphone iphone= new Iphone("(99)99999-9999","Iphone Z","000000-00-000000-0", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Gmail");