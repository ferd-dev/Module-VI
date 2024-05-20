using practica2;

Console.WriteLine("1");
var numberList = new PractList();
numberList.print();
numberList.delete();
numberList.print();

Console.WriteLine("2");

var students = new PractDictionaries();
students.printPar();
students.updateAndDelete();
students.printPar();

Console.WriteLine("3");

var customers = new PractQueues();
customers.print();
customers.deleteCustomer();
customers.deleteCustomer();
customers.print();