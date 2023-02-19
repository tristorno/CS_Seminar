// Прогорамма выводит рандомное трехначное число и удаляет вторую цифру
System.Random numRandomizer = new System.Random();
//V1
int rndNum = numRandomizer.Next (100,1000);
Console.WriteLine("Сгенерировано - " + rndNum);
int num1 = rndNum / 100;
//int num2 = rndNum / 10 % 10;
int num3 = rndNum % 100 % 10;
int res = num1 * 10 + num3;
Console.WriteLine("Получилось " + res);
