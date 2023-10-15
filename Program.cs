using DesafioPOO.Models;

// Criar uma instância de Nokia
Nokia nokia = new Nokia("123456", "Nokia Modelo X", "ABC123", 64);

// Criar uma instância de Iphone
Iphone iphone = new Iphone("654321", "iPhone 12", "XYZ789", 128);

// Testar métodos herdados da classe Smartphone
Console.WriteLine("Testando métodos herdados da classe Smartphone:");
nokia.Ligar();
iphone.ReceberLigacao();

// Testar método específico de Nokia
Console.WriteLine("\nTestando método específico de Nokia:");
nokia.InstalarAplicativo("JogoNokia");

// Testar método específico de Iphone
Console.WriteLine("\nTestando método específico de Iphone:");
iphone.InstalarAplicativo("JogoIphone");

// Aguarde a entrada do usuário antes de fechar a aplicação
Console.ReadLine();