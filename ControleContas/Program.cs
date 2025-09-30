using ControleContas;

Conta conta1 = new Conta(123456789);
Conta conta2 = new Conta();
Conta saldo1 = new Conta(2000);
Console.WriteLine($"O número da conta é {conta1.Numero}");
Console.WriteLine($"O número da conta é {conta2.Numero}"); //Numero em get publico

//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura