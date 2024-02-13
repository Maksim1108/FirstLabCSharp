using FirstLab;
using FirstLab.algorithms;
using FirstLab.fileWork;
using FirstLab.interfacee;
using FirstLab.tests;
using FirstLab.validation;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        Interfacee interfacee = new Interfacee();
        InputValidation inputValidation = new InputValidation();
        Algorithms algorithms = new Algorithms();
        FileWork fileWork = new FileWork();
        Tests tests = new Tests();
        MENU_ITEMS userMenuChoice;

        double x1, y1, x2, y2, x3, y3, x4, y4;

        string filePath;

        interfacee.showInfo();

        do
        {
            interfacee.showMenu();
            Console.Write("> ");
            userMenuChoice = inputValidation.getMenuItems();

            switch (userMenuChoice)
            {
                case MENU_ITEMS.START_PROGRAMM:
                    INPUT_CHOICE choice;
                    SUBMENU subMenuChoice;
                    interfacee.showInputTypeChoice();
                    do
                    {
                        choice = inputValidation.getChoice();
                        
                        switch(choice)
                        {
                            case INPUT_CHOICE.BY_HANDS:
                                // Ввод координат прямоугольника
                                Console.WriteLine("Введите координаты прямоугольника:");
                                Console.WriteLine("Верхняя левая точка (x1, y1): ");
                                Console.Write("x1: ");
                                x1 = double.Parse(Console.ReadLine());
                                Console.Write("y1: ");
                                y1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Нижняя правая точка (x2, y2): ");
                                Console.Write("x2: ");
                                x2 = double.Parse(Console.ReadLine());
                                Console.Write("y2: ");
                                y2 = double.Parse(Console.ReadLine());

                                // Ввод координат отрезка
                                Console.WriteLine("\nВведите координаты отрезка:");
                                Console.WriteLine("Начальная точка (x3, y3): ");
                                Console.Write("x3: ");
                                x3 = double.Parse(Console.ReadLine());
                                Console.Write("y3: ");
                                y3 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Конечная точка (x4, y4): ");
                                Console.Write("x4: ");
                                x4 = double.Parse(Console.ReadLine());
                                Console.Write("y4: ");
                                y4 = double.Parse(Console.ReadLine());

                                // Проверка пересечения
                                //algorithms.outputResult(x1, y1, x2, y2, x3, y3, x4, y4);

                                if (algorithms.doIntersect(x1, y1, x2, y2, x3, y3, x4, y4))
                                {
                                    // Нахождение координат точек пересечения
                                    double[] intersection = algorithms.findIntersection(x1, y1, x2, y2, x3, y3, x4, y4);
                                    Console.WriteLine($"\nОтрезок и прямоугольник пересекаются. Координаты точки пересечения: ({intersection[0]}, {intersection[1]})\n");
                                    
                                    if(intersection.Length > 0)
                                    {
                                        Console.WriteLine("Хотите сохранить координаты точки пересечения?\n");
                                        interfacee.showChoice();
                                        subMenuChoice = inputValidation.getSubMenuChoice();

                                        switch (subMenuChoice)
                                        {
                                            case SUBMENU.YES:
                                                fileWork.saveOnFile(intersection[0], intersection[1]);
                                                Console.WriteLine("\nДанные успешно сохранены !");
                                                break;
                                            case SUBMENU.NO:
                                                Console.WriteLine("\nВы решили не сохранять данные в файл");
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nОтрезок и прямоугольник не пересекаются.\n");
                                }
                                break;

                            case INPUT_CHOICE.LOAD_FROM_FILE:
                                Console.WriteLine("\n[!]Загрузка из файла");
                                Console.Write("\nВведите название файла:\n> ");
                                filePath = Console.ReadLine();
                                fileWork.loadFromFile(filePath, out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);

                                if (algorithms.doIntersect(x1, y1, x2, y2, x3, y3, x4, y4))
                                {
                                    // Нахождение координат точек пересечения
                                    double[] intersection = algorithms.findIntersection(x1, y1, x2, y2, x3, y3, x4, y4);
                                    Console.WriteLine($"\nОтрезок и прямоугольник пересекаются. Координаты точки пересечения: ({intersection[0]}, {intersection[1]})\n");

                                    if (intersection.Length > 0)
                                    {
                                        Console.WriteLine("Хотите сохранить координаты точки пересечения?\n");
                                        interfacee.showChoice();
                                        subMenuChoice = inputValidation.getSubMenuChoice();

                                        switch (subMenuChoice)
                                        {
                                            case SUBMENU.YES:
                                                fileWork.saveOnFile(intersection[0], intersection[1]);
                                                Console.WriteLine("\nДанные успешно сохранены !");
                                                break;
                                            case SUBMENU.NO:
                                                Console.WriteLine("\nВы решили не сохранять данные в файл");
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nОтрезок и прямоугольник не пересекаются.\n");
                                }
                                break;
                        }
                    } while (choice != INPUT_CHOICE.BY_HANDS && choice != INPUT_CHOICE.LOAD_FROM_FILE);
                    
                    break;

                case MENU_ITEMS.START_TESTS:
                    tests.runAllTests();
                    break;

                case MENU_ITEMS.QUIT:
                    Console.WriteLine("\nЗавершение работы программы.");
                    break;

                default:
                    Console.WriteLine("Неправильный ввод. Попробуйте снова.\n");
                    break;
            }
        } while (userMenuChoice != MENU_ITEMS.QUIT);
    }
}