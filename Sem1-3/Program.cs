//Прогорамма показываеь день недели по ее номеру
//
Console.WriteLine ("Введите число:");
int num = Convert.ToInt16 (Console.ReadLine ());
string [] weekDay = new string [7];
weekDay [1] = "понедельник"; 
weekDay [2] = "вторник";
weekDay [3] = "среда";
weekDay [4] = "четверг";
weekDay [5] = "пятница";
weekDay [6] = "суббота";
weekDay [0] = "воскресенье";
int dayIndex = num % 7;
Console.WriteLine (weekDay [dayIndex]);
