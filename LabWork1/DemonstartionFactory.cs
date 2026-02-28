using System;

namespace LabWork1
{
    internal class DemonstartionFactory
    {
        public static void Main()
        {
            var factory = new Factory(
                1,
                "Завод «ТехноПро»",
                "г. Гомель, ул. Промышленная, 12",
                1998
            );

            Console.WriteLine(factory.Describe());
            Console.WriteLine();

            Console.WriteLine("ЦЕХА ЗАВОДА");

            var workshop1 = new Workshop(10, "TS-01", "Цех резки металла", factory.GetId(), 1500);
            var workshop2 = new Workshop(11, "TS-02", "Сварочный цех", factory.GetId(), 900);

            factory.AddWorkshop(workshop1);
            factory.AddWorkshop(workshop2);

            Console.WriteLine($"{workshop1.GetName()} — {workshop1.GetAreaSqM()} м²");
            Console.WriteLine($"{workshop2.GetName()} — {workshop2.GetAreaSqM()} м²");
            Console.WriteLine();

            Console.WriteLine("СОТРУДНИКИ");

            var worker1 = new Worker(101, "Иван Петров", "Оператор станка", workshop1.GetId(), 23.5);
            var worker2 = new Worker(102, "Сергей Иванов", "Сварщик", workshop2.GetId(), 26.0);
            var engineer = new Engineer(201, "Инженер Клаус", 45);

            Console.WriteLine($"{worker1.GetFullName()} — {worker1.GetRole()}");
            Console.WriteLine($"{worker2.GetFullName()} — {worker2.GetRole()}");
            Console.WriteLine($"{engineer.GetFullName()} — {engineer.GetRole()}");
            Console.WriteLine();

            Console.WriteLine("СТАНКИ");

            var machine1 = new Machine(100, "TS-001", "CNC-5000", workshop1.GetId());
            var machine2 = new Machine(101, "TS-002", "LaserCut-3000", workshop2.GetId());

            workshop1.AddMachine(machine1);
            workshop2.AddMachine(machine2);

            machine1.Start();
            machine1.AddHours(5);
            machine1.Stop();

            Console.WriteLine($"{machine1.GetModel()} — {machine1.GetHoursWorked()} ч");
            Console.WriteLine();

            Console.WriteLine("ТИПЫ ПРОДУКЦИИ");

            var product1 = new ProductType(300, "STL-10", "Стальная плита 10 мм", "Горячекатаная плита", 6);
            var product2 = new ProductType(301, "BEAM-20", "Балка двутавровая 20 см", "Стальная балка", 14);

            Console.WriteLine($"{product1.GetName()} — цикл {product1.GetStandardCycleTimeMin()} мин");
            Console.WriteLine($"{product2.GetName()} — цикл {product2.GetStandardCycleTimeMin()} мин");
            Console.WriteLine();

            Console.WriteLine("ПРОИЗВОДСТВЕННЫЕ ЗАКАЗЫ");

            var order1 = new ProductionOrder(
                400,
                "TS-ORD-001",
                product1,
                1200,
                "2026-03-01",
                "2026-03-07"
            );

            order1.AssignPerson(worker1);
            order1.AssignPerson(worker2);
            order1.AssignPerson(engineer);

            order1.Start();
            order1.Complete();

            Console.WriteLine($"{order1.GetOrderNumber()} — статус {order1.GetStatus()}");
            Console.WriteLine();

            Console.WriteLine("ПРОВЕРКА КАЧЕСТВА");

            var qc1 = new QualityCheck(
                500,
                order1,
                product1,
                engineer,
                "PASSED",
                3
            );

            Console.WriteLine($"Проверка: {qc1.GetResult()}, инспектор {qc1.GetInspector().GetFullName()}");
            Console.WriteLine();

            Console.WriteLine("ОБСЛУЖИВАНИЕ");

            var task1 = new MaintenanceTask(
                600,
                machine1,
                "Замена режущего инструмента",
                "2026-03-05"
            );

            task1.MarkCompleted();
            Console.WriteLine($"Задача: {task1.GetDescription()}, выполнена: {task1.IsCompleted()}");
            Console.WriteLine();

            Console.WriteLine("ИНЦИДЕНТЫ");

            var incident1 = new SafetyIncident(
                800,
                "2026-03-02",
                workshop1,
                "Порез руки при резке металла",
                "LOW"
            );

            Console.WriteLine($"Инцидент в {incident1.GetWorkshop().GetName()}: {incident1.GetDescription()}");
            Console.WriteLine();


            Console.WriteLine("РЕПОЗИТОРИИ (ПАРАМЕТРИЧЕСКИЙ ПОЛИМОРФИЗМ)");

            var machineRepo = new Repository<Machine>();
            machineRepo.Add(machine1);
            machineRepo.Add(machine2);

            var personRepo = new Repository<Person>();
            personRepo.Add(worker1);
            personRepo.Add(worker2);
            personRepo.Add(engineer);

            Console.WriteLine($"В репозитории станков: {machineRepo.Count()} шт.");
            Console.WriteLine($"В репозитории сотрудников: {personRepo.Count()} чел.");
            Console.WriteLine();
        }
    }
}


