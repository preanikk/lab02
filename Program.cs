// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte:  {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int:   {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long:  {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов");
// Console.WriteLine($"float:   {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");


// Console.WriteLine();
// Console.WriteLine("Переполнение byte");
// byte maxByte = 255;
// byte overfloved = (byte)(maxByte + 1);
// Console.WriteLine($"255 + 1 для byte = {overfloved}");


// Console.WriteLine();
// Console.WriteLine("char");
// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter;
// Console.WriteLine($"Символ {firstLetter}, разделитель: {separator}");
// Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// Console.WriteLine($"Табуляция:\t после таба");
// Console.WriteLine($"Перенос:\n после переноса");


// Console.WriteLine();
// Console.WriteLine("decimal против double");
// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;
// Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");


// Console.WriteLine();
// Console.WriteLine("var");
// var studentAge = 20;
// var gpa = 4.75;
// var fullName = "Смирнова А. С.";
// Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");


// Console.WriteLine();
// Console.WriteLine("Ввод текста");
// Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();
// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();
// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");
// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();
// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse: {birthYearParse}");
// Console.WriteLine($"в 2030 году вам будет {2030 - birthYearConvert} лет");


// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Tryparse");
// Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();
// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);
// Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// Console.WriteLine($"Значение переменной booksCount: {booksCount}");


// Console.Write("Введите имя и фамилию: ");
// string enteredName = Console.ReadLine();
// Console.Write("Введите группу: ");
// string enteredGroup = Console.ReadLine();
// Console.Write("Введите год рождения: ");
// int enteredYear = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл: ");
// double enteredBall = double.Parse(Console.ReadLine());
// Console.Write("Введите любимую букву: ");
// char enteredBukva = Console.ReadLine()[0];

// bool avgGrade = enteredBall >= 4.0;
// int age2030 = 2030 - enteredYear;

// Console.WriteLine("    Анкета");
// Console.WriteLine($"{enteredName}, группа {enteredGroup}");
// Console.WriteLine($"Год рождения: {enteredYear} (в 2030 будет {age2030} год)");
// Console.WriteLine($"Средний балл: {enteredBall}");
// Console.WriteLine($"Балл >=4: {avgGrade}");
// Console.WriteLine($"Любимая буква: {enteredBukva}");


// Console.Write("Введите ваш рост: ");
// double rost = double.Parse(Console.ReadLine());
// Console.Write("Введите ваш вес: ");
// double ves = double.Parse(Console.ReadLine());
// double bmi = ves / (rost * rost);
// Console.WriteLine($"ИМТ: {bmi:F2}");



Console.Write("Введите фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите имя: ");
string name = Console.ReadLine();
char name1 = name[0];
Console.WriteLine($"{surname} {name1}.");