
Menu();

static void Menu()
{
  int operation;

  Console.Clear();
  Console.WriteLine("O que deseja fazer: \n 1- Soma\n 2- Subtração\n 3- Multiplicação\n 4- Divisão\n 5- Sair");

  operation = int.Parse(Console.ReadLine());

  switch (operation)
  {
    case 1:
      Somar();
      break;
    case 2:
      Subtrair();
      break;
    case 3:
      Multiplicar();
      break;
    case 4:
      Dividir();
      break;
    case 5:
      System.Environment.Exit(0);
      break;
    default:
      break;
  }

}

static void Somar()
{
  Console.WriteLine("Primeiro valor: ");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor: ");
  float v2 = float.Parse(Console.ReadLine());
  Console.WriteLine("O resultado da soma é: " + (v1 + v2));
  Console.ReadKey();
  Menu();
}
static void Subtrair()
{
  Console.WriteLine("Primeiro valor: ");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor: ");
  float v2 = float.Parse(Console.ReadLine());
  Console.WriteLine("O resultado da subtração é: " + (v1 - v2));
  Console.ReadKey();
  Menu();
}
static void Multiplicar()
{
  Console.WriteLine("Primeiro valor: ");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor: ");
  float v2 = float.Parse(Console.ReadLine());
  Console.WriteLine("O resultado da multiplicação é: " + (v1 * v2));
  Console.ReadKey();
  Menu();
}
static void Dividir()
{
  Console.WriteLine("Primeiro valor: ");
  float v1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Segundo valor: ");
  float v2 = float.Parse(Console.ReadLine());
  Console.WriteLine("O resultado da divisão é: " + (v1 + v2));
  Console.ReadKey();
  Menu();
}
