using System;


namespace RPPOON_LV6 {
    class Program
    {
        static void Main()
        {
            //1,2
            Note firstNote = new Note("Prva biljeska", "Labosi");
            Note secondNote = new Note("Druga biljeska", "Kolokvij");
            Note thirdNote = new Note("Treca biljeska", "Kolokvij");


            Notebook notebook =new Notebook();
            notebook.AddNote(firstNote);
            notebook.AddNote(secondNote);
            notebook.AddNote(thirdNote);

            IAbstractIterator iterator=notebook.GetIterator();

            do
            {
                iterator.Current.Show();

            } while (iterator.Next() != null);

            //3,4
            ToDoItem toDoItem = new ToDoItem("Kolokvij", "Uciti za kolokvij", DateTime.Now);
            CareTaker caretaker=new CareTaker();
            caretaker.AddState(toDoItem.StoreState());
            Console.WriteLine(toDoItem.ToString());

            toDoItem.Rename("Kolokvij KM");
            toDoItem.ChangeTask("Pripremiti skriptu");
            Console.WriteLine(toDoItem.ToString());

            toDoItem.RestoreState(caretaker.PreviousState);
            Console.WriteLine(toDoItem.ToString());

            //5,6,7
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            logger.SetNextLogger(fileLogger);
            logger.Log("Info poruka", MessageType.INFO);
            logger.Log("Warning poruka", MessageType.WARNING);

            StringChecker stringChecker = new StringDigitChecker();
            StringLengthChecker stringLengthChecker = new StringLengthChecker(5);
            StringLowerCaseChecker stringLowerCaseChecker = new StringLowerCaseChecker();

            stringChecker.SetNext(stringLengthChecker);
            stringLengthChecker.SetNext(stringLowerCaseChecker);

            Console.Write(stringChecker.Check("Provjeriti sadrzi li sv3."));
        }
    }
}