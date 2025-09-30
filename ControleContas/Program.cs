using ControleContas;

Conta conta1 = new Conta(123456789);
Conta conta2 = new Conta();

Console.WriteLine($"O número da conta é {conta1.Numero}");
Console.WriteLine($"O número da conta é {conta2.Numero}"); //Numero em get publico

//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura
//TDD
//crie im projeto de teste para testar a classe Conta ele deverátestar um método depositar
//o método depositar deverá receber um valor decimal positivo e incrementar o saldo da cont