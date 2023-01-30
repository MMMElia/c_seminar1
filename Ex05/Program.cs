Console.Clear();
Console.Write("Введите число:  ");
int n =int.Parse(Console.ReadLine());

int i = n*-1;

while (i<=n) {
    //Console.Write(i); 
    Console.Write($"{i} "); 
    i=i+1;
}

