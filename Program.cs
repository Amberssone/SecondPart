
// Задача номер 2 
string numbers = Console.ReadLine();

string[] numbersArray = numbers.Split(' ');

string number1 = numbersArray[0];
string number2 = numbersArray[1];
int number1Int = Int32.Parse(number1);
int number2Int = Int32.Parse(number2);

if (number1Int > number2Int) {
    Console.WriteLine(number1Int);
}
else {
    Console.WriteLine(number2Int);
}

// Задача номер 4

Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            //3
            if (first > second)
            {
                //4
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }


// Задача номер 6

string number = Console.ReadLine();

int numberInt = Int32.Parse(number);

if (numberInt % 2 == 0) {
    Console.WriteLine("Yes");
}
else {
    Console.WriteLine("No");
}


// Задача номер 8 

string n = Console.ReadLine();

int nInt = Int32.Parse(n);

for (int i = 1; i <= nInt; i++) {
    if (i % 2 == 0) {
         Console.WriteLine(i);
    }
}


