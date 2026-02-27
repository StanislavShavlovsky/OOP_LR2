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

            Console.WriteLine($"{workshop1.GetId()}: {workshop1.GetName()}, площадь {workshop1.GetAreaSqM()} м²");
            Console.WriteLine($"{workshop2.GetId()}: {workshop2.GetName()}, площадь {workshop2.GetAreaSqM()} м²");
            Console.WriteLine();


            Console.WriteLine("СОТРУДНИКИ (НАСЛЕДОВАНИЕ + ПОЛИМОРФИЗМ)");

            var worker1 = new Worker(101, "Иван Петров", "Оператор станка", workshop1.GetId(), 23.5);
            var worker2 = new Worker(102, "Сергей Иванов", "Сварщик", workshop2.GetId(), 26.0);

            var engineer = new Engineer(201, "Инженер Клаус", 45);
            var manager = new Manager(301, "Анна Смирнова", 38);

            Console.WriteLine($"{worker1.GetFullName()} — роль: {worker1.GetRole()}");
            Console.WriteLine($"{worker2.GetFullName()} — роль: {worker2.GetRole()}");
            Console.WriteLine($"{engineer.GetFullName()} — роль: {engineer.GetRole()}");
            Console.WriteLine($"{manager.GetFullName()} — роль: {manager.GetRole()}");
            Console.WriteLine();


            Console.WriteLine("СМЕНЫ");

            var shiftMorning = new Shift(1, "Утренняя смена", 6, 14, 25);
            var shiftEvening = new Shift(2, "Вечерняя смена", 14, 22, 20);

            Console.WriteLine($"{shiftMorning.GetCode()}, длительность {shiftMorning.DurationHours()} ч");
            Console.WriteLine($"{shiftEvening.GetCode()}, длительность {shiftEvening.DurationHours()} ч");
            Console.WriteLine();



            Console.WriteLine("СТАНКИ");

            var machine1 = new Machine(100, "TS-001", "CNC-5000", workshop1.GetId());
            var machine2 = new Machine(101, "TS-002", "LaserCut-3000", workshop2.GetId());

            workshop1.AddMachine(machine1);
            workshop2.AddMachine(machine2);

            Console.WriteLine($"{machine1.GetId()}: {machine1.GetModel()}, статус {machine1.GetStatus()}");
            Console.WriteLine($"{machine2.GetId()}: {machine2.GetModel()}, статус {machine2.GetStatus()}");

            machine1.Start();
            machine1.AddHours(4.5);   // double
            machine1.AddHours(2);     // int (перегрузка)
            machine1.Stop();

            Console.WriteLine($"После работы: {machine1.GetStatus()}, наработано {machine1.GetHoursWorked()} ч");
            Console.WriteLine();


            Console.WriteLine("ТИПЫ ПРОДУКЦИИ");

            var product1 = new ProductType(300, "STL-10", "Стальная плита 10 мм", "Горячекатаная плита", 6);
            var product2 = new ProductType(301, "BEAM-20", "Балка двутавровая 20 см", "Стальная балка", 14);

            Console.WriteLine($"{product1.GetId()}: {product1.GetName()}, цикл {product1.GetStandardCycleTimeMin()} мин");
            Console.WriteLine($"{product2.GetId()}: {product2.GetName()}, цикл {product2.GetStandardCycleTimeMin()} мин");
            Console.WriteLine();



            Console.WriteLine("ПРОИЗВОДСТВЕННЫЕ ЗАКАЗЫ");

            var order1 = new ProductionOrder(
                400,
                "TS-ORD-001",
                product1.GetId(),
                1200,
                "2026-03-01",
                "2026-03-07"
            );

            order1.AssignPerson(worker1);
            order1.AssignPerson(worker2);
            order1.AssignPerson(engineer);

            Console.WriteLine($"Заказ {order1.GetOrderNumber()}, статус {order1.GetStatus()}");
            order1.Start();
            Console.WriteLine($"После запуска: {order1.GetStatus()}");
            order1.Complete();
            Console.WriteLine($"После завершения: {order1.GetStatus()}");
            Console.WriteLine();


            Console.WriteLine("ПРОВЕРКА КАЧЕСТВА");

            var qc1 = new QualityCheck(
                500,
                order1.GetId(),
                product1.GetId(),
                engineer,
                "PASSED",
                3
            );

            Console.WriteLine($"Проверка заказа {order1.GetOrderNumber()}: результат {qc1.GetResult()}, дефектов {qc1.GetDefectsCount()}");
            Console.WriteLine($"Инспектор: {qc1.GetInspector().GetFullName()}, роль: {qc1.GetInspector().GetRole()}");
            Console.WriteLine($"Прошла проверку: {(qc1.IsPassed() ? "да" : "нет")}");
            Console.WriteLine();


            Console.WriteLine("ОБСЛУЖИВАНИЕ");

            var task1 = new MaintenanceTask(
                600,
                machine1.GetId(),                    
                "Замена режущего инструмента",
                "2026-03-05"
            );

            Console.WriteLine($"Задача: {task1.GetDescription()}, выполнена {task1.IsCompleted()}");
            task1.MarkCompleted();
            Console.WriteLine($"После выполнения: {task1.IsCompleted()}");
            Console.WriteLine();


            Console.WriteLine("СКЛАД");

            var storage1 = new StorageUnit(700, "TS-ST-01", 6000);
            storage1.AddLoad(3500);

            Console.WriteLine($"Склад {storage1.GetCode()}, загрузка {storage1.GetCurrentLoadKg()} / {storage1.GetCapacityKg()} кг");
            Console.WriteLine();


            Console.WriteLine("ИНЦИДЕНТЫ");

            var incident1 = new SafetyIncident(
                800,
                "2026-03-02",
                workshop1.GetId(),
                "Порез руки при резке металла",
                "LOW"
            );

            Console.WriteLine($"Инцидент: {incident1.GetDescription()}, серьёзность {incident1.GetSeverity()}");
            Console.WriteLine();
        }
    }
}

