int a = 2;

switch (a)
{
    case 1:
    case 2:
    case 3:
        System.Console.WriteLine ("3");
        break;
    default:
        System.Console.WriteLine ("7"); //Выведет 7, потмоу что ни одному предыдщему кейсу а не соответ-ло
        break;
}