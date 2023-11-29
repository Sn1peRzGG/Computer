using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    class Computer
    {
        internal Motherboard Motherboard { get; set; } = new Motherboard();
        internal PowerSupply PowerSupply { get; set; } = new PowerSupply();
    }

    class ComputerComponent
    {
        internal string Name { get; set; }
        internal int Cost { get; set; }
    }

    class Motherboard : ComputerComponent
    {
        internal List<CPU> CpuSlots { get; set; } = new List<CPU>();
        internal List<GPU> GpuSlots { get; set; } = new List<GPU>();
        internal List<RAM> RamSlots { get; set; } = new List<RAM>();
        internal List<SSD> SsdSlots { get; set; } = new List<SSD>();
        internal List<PowerSupply> Power { get; set; } = new List<PowerSupply>();
    }

    class SSD : ComputerComponent
    {
        internal string Capacity { get; set; }
        internal int Speed { get; set; }
    }

    class RAM : ComputerComponent
    {
        internal int Amount { get; set; }
        internal string Type { get; set; }
        internal int Frequency { get; set; }
    }

    class CPU : ComputerComponent
    {
        internal double Frequency { get; set; }
        internal double Cores { get; set; }
    }

    class GPU : ComputerComponent
    {
        internal int Amount { get; set; }
        internal int Memory { get; set; }
        internal string MemoryType { get; set; }
    }

    class PowerSupply : ComputerComponent
    {
        internal int Power { get; set; }
        internal string Capacity { get; set; }
        internal string Certificate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool isWork = true;

            while (isWork == true)
            {
                Console.WriteLine($"Оберіть збірку: \n\t1 - Intel Core i3-13100F і Nvidia GTX 1660Ti\n\t2 - Intel Core i5-12400F і Nvidia GEFORCE RTX 3060\n\t3 - Intel Core i7-12700K і Nvidia GEFORCE RTX 4070Ti\n\t4 - Intel Core i9-14900KS і Nvidia GEFORCE RTX 4090Ti\n\t5 - Налаштувати власний ПК\n\t0 - Вихід");
                //int userSelect = Convert.ToInt32(Console.ReadLine().Trim());
                string userSelect = Console.ReadLine().Trim();

                Computer userComputer = new Computer();

                switch (userSelect)
                {
                    case "1":
                        userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i3-13100F", Cost = 4690, Frequency = 3.4, Cores = 4 });
                        userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce GTX 1660Ti", Cost = 9967, Memory = 6, MemoryType = "GDDR6" });
                        userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston Fury RGB Black", Cost = 1699, Amount = 16, Type = "DDR4", Frequency = 3200 });
                        userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Kingston", Cost = 1099, Capacity = "480 GB", Speed = 500 });
                        userComputer.Motherboard.Power.Add(new PowerSupply { Name = "Deepcool", Cost = 1199, Capacity = "500W" });
                        break;

                    case "2":
                        userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i5-12400F", Cost = 5779, Frequency = 2.5, Cores = 6 });
                        userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 3060", Cost = 13299, Memory = 12, MemoryType = "GDDR6" });
                        userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Corsair Vengeance LPX", Cost = 1809, Amount = 16, Type = "DDR4", Frequency = 3200 });
                        userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Kingston M.2", Cost = 2419, Capacity = "1 TB", Speed = 3500 });
                        userComputer.Motherboard.Power.Add(new PowerSupply { Name = "ASUS TUF Gaming", Cost = 4609, Capacity = "750W", Certificate = "80+ Bronze" });
                        break;

                    case "3":
                        userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i7-12700K", Cost = 19259, Frequency = 3.6, Cores = 12 });
                        userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4070Ti", Cost = 43584, Memory = 12, MemoryType = "GDDR6X" });
                        userComputer.Motherboard.RamSlots.Add(new RAM { Name = "G.Skill Trident Z RGB", Cost = 3718, Amount = 32, Type = "DDR4", Frequency = 3200 });
                        userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Samsung 970 EVO Plus", Cost = 3849, Capacity = "1 TB", Speed = 3500 });
                        userComputer.Motherboard.Power.Add(new PowerSupply { Name = "ASUS ROG Strix", Cost = 9516, Capacity = "1000W", Certificate = "80+ Gold" });
                        break;
                    case "4":
                        userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i9-14900KS", Cost = 26999, Frequency = 4.4, Cores = 24 });
                        userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4090Ti", Cost = 110773, Memory = 24, MemoryType = "GDDR6X" });
                        userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston FURY Renegade", Cost = 11305, Amount = 64, Type = "DDR5", Frequency = 6000 });
                        userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Samsung 990 Pro", Cost = 6999, Capacity = "2 TB", Speed = 7450 });
                        userComputer.Motherboard.Power.Add(new PowerSupply { Name = "ASUS ROG Thor", Cost = 32345, Capacity = "1600W", Certificate = "80+ Titanium" });
                        break;
                    case "5":
                        Console.WriteLine($"Оберіть процесор: \n\t1 - Intel Core i3-10100F 3.6GHz\n\t2 - AMD Ryzen 5 3600 3.6GHz\n\t3 - Intel Core i5-12400F 2.5GHz\n\t4 - AMD Ryzen 7 5800X 3.8GHz\n\t5 - Intel Core i7-12700F 2.9GHz\n\t6 - AMD Ryzen 7 7700X 4.5GHz\n\t7 - Intel Core i7-13700KF 3.4GHz\n\t8 - AMD Ryzen 9 7950X 4.5GHz\n\t9 - Intel Core i9-13900KF 3.0GHz");
                        //int Procerror = Convert.ToInt32(Console.ReadLine().Trim());
                        string Procerror = Console.ReadLine().Trim();
                        if (Procerror == "1")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i3-10100F", Cost = 3978, Frequency = 3.6, Cores = 4 });
                        }
                        else if (Procerror == "2")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "AMD Ryzen 5 3600", Cost = 3559, Frequency = 3.6, Cores = 6 });
                        }
                        else if (Procerror == "3")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i5-12400F", Cost = 6667, Frequency = 2.5, Cores = 6 });
                        }
                        else if (Procerror == "4")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "AMD Ryzen 7 5800X", Cost = 8299, Frequency = 3.8, Cores = 8 });
                        }
                        else if (Procerror == "5")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i7-12700F", Cost = 12712, Frequency = 2.9, Cores = 12 });
                        }
                        else if (Procerror == "6")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "AMD Ryzen 7 7700X", Cost = 13053, Frequency = 4.5, Cores = 8 });
                        }
                        else if (Procerror == "7")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i7-13700KF", Cost = 17105, Frequency = 3.4, Cores = 16 });
                        }
                        else if (Procerror == "8")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "AMD Ryzen 9 7950X", Cost = 24999, Frequency = 4.5, Cores = 16 });
                        }
                        else if (Procerror == "9")
                        {
                            userComputer.Motherboard.CpuSlots.Add(new CPU { Name = "Intel Core i9-13900KF", Cost = 24613, Frequency = 3.0, Cores = 24 });
                        }
                        else
                        {
                            Console.WriteLine($"Помилка введення.");
                            return;
                        }
                        Console.WriteLine($"Оберіть відеокарту: \n\t1 - Nvidia GeForce GTX 1650 4GB\n\t2 - AMD Radeon RX 6500 XT 4GB\n\t3 - AMD Radeon RX 6600 8GB\n\t4 - Nvidia GeForce RTX 3060 12GB\n\t5 - AMD Radeon RX 6800 XT 16GB\n\t6 - Nvidia GeForce RTX 4070 12GB\n\t7 - Nvidia GeForce RTX 4070Ti 12GB\n\t8 - AMD Radeon RX 7900 XTX 24GB\n\t9 - Nvidia GeForce RTX 4080 16GB\n\t10 - Nvidia GeForce RTX 4090 24GB");
                        //int GraphicsCard = Convert.ToInt32(Console.ReadLine().Trim());
                        string GraphicsCard = Console.ReadLine().Trim();
                        if (GraphicsCard == "1")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce GTX 1650", Cost = 7527, Memory = 4, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "2")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "AMD Radeon RX 6500 XT", Cost = 8214, Memory = 4, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "3")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "AMD Radeon RX 6600", Cost = 9999, Memory = 8, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "4")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 3060", Cost = 12999, Memory = 12, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "5")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "AMD Radeon RX 6800 XT", Cost = 21029, Memory = 16, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "6")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4070", Cost = 28938, Memory = 12, MemoryType = "GDDR6X" });
                        }
                        else if (GraphicsCard == "7")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4070Ti", Cost = 35646, Memory = 12, MemoryType = "GDDR6X" });
                        }
                        else if (GraphicsCard == "8")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "AMD Radeon RX 7900 XTX", Cost = 50530, Memory = 24, MemoryType = "GDDR6" });
                        }
                        else if (GraphicsCard == "9")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4080", Cost = 51199, Memory = 16, MemoryType = "GDDR6X" });
                        }
                        else if (GraphicsCard == "10")
                        {
                            userComputer.Motherboard.GpuSlots.Add(new GPU { Name = "Nvidia GeForce RTX 4090", Cost = 121352, Memory = 24, MemoryType = "GDDR6X" });
                        }
                        else
                        {
                            Console.WriteLine($"Помилка введення.");
                            return;
                        }
                        Console.WriteLine($"Оберіть оперативну пам'ять: \n\t1 - Corsair Vengeance LPX Black 16GB\n\t2 - Corsair Vengeance RGB Black 32GB\n\t3 - Corsair Vengeance Black 64GB\n\t4 - Kingston Fury Beast RGB Black 64GB\n\t5 - Kingston Fury Beast Black 128GB\n\t6 - Kingston Fury Beast RGB Black 128GB\n\t7 - G.Skill Trident Z Royal 32GB\n\t8 - Kingston Fury Renegade RGB 96GB\n\t9 - G.Skill Trident Z5 RGB Black 96GB");
                        //int RAM = Convert.ToInt32(Console.ReadLine().Trim());
                        string RAM = Console.ReadLine().Trim();
                        if (RAM == "1")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Corsair Vengeance LPX Black", Cost = 1809, Amount = 16, Type = "DDR4", Frequency = 3200 });
                        } 
                        else if (RAM == "2")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM {Name = "Corsair Vengeance RGB Black", Cost = 6899, Amount = 32, Type = "DDR5", Frequency = 7200 });
                        }
                        else if (RAM == "3")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM {Name = "Corsair Vengeance Black", Cost = 9099, Amount = 64, Type = "DDR5", Frequency = 5600 });
                        }
                        else if (RAM == "4")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston Fury Beast RGB Black", Cost = 9609, Amount = 64, Type = "DDR5", Frequency = 5200 });
                        }
                        else if (RAM == "5")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston Fury Beast Black", Cost = 12132, Amount = 128, Type = "DDR4", Frequency = 3600 });
                        }
                        else if (RAM == "6")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston Fury Beast RGB Black", Cost = 12753, Amount = 128, Type = "DDR4", Frequency = 3600 });
                        }
                        else if (RAM == "7")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "G.Skill Trident Z Royal", Cost = 15693, Amount = 32, Type = "DDR4", Frequency = 3600 });
                        }
                        else if (RAM == "8")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "Kingston Fury Renegade RGB", Cost = 16499, Amount= 96, Type = "DDR5", Frequency = 6000 });
                        }
                        else if (RAM == "9")
                        {
                            userComputer.Motherboard.RamSlots.Add(new RAM { Name = "G.Skill Trident Z5 RGB Black", Cost = 18466, Amount = 96, Type = "DDR5", Frequency = 6400 });
                        }
                        else
                        {
                            Console.WriteLine($"Помилка введення.");
                            return;
                        }
                        Console.WriteLine($"Оберіть SSD: \n\t1 - Goodram PX600 500GB\n\t2 - Samsung 970 EVO Plus 1TB\n\t3 - Kingston FURY Renegade 1TB\n\t4 - Samsung 990 Pro 1TB\n\t5 - Kingston FURY Renegade 4TB");
                        //int ssdChoice = Convert.ToInt32(Console.ReadLine().Trim());
                        string ssd = Console.ReadLine().Trim();
                        if (ssd == "1")
                        {
                            userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Goodram PX600", Cost = 1472, Capacity = "500GB", Speed = 4700 });
                        }
                        else if (ssd == "2")
                        {
                            userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Samsung 970 Evo Plus", Cost = 2999, Capacity = "1TB", Speed = 3500 });
                        }
                        else if (ssd == "3")
                        {
                            userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Kingston FURY Renegade", Cost = 3379, Capacity = "1TB", Speed = 7300 });
                        }
                        else if (ssd == "4")
                        {
                            userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Samsung 990 Pro", Cost = 4999, Capacity = "1TB", Speed = 7450 });
                        }
                        else if (ssd == "5")
                        {
                            userComputer.Motherboard.SsdSlots.Add(new SSD { Name = "Kingston FURY Renegade", Cost = 19679, Capacity = "4TB", Speed = 7300 });
                        }
                        else
                        {
                            Console.WriteLine($"Помилка введення.");
                            return;
                        }

                        Console.WriteLine($"Оберіть блок живлення (БЖ): \n\t1 - Aerocool KCAS Plus 1200W\n\t2 - Chieftec Polaris 850W\n\t3 - Be Quiet! Straight Power 11 Platimun 850W\n\t4 - NZXT C Series 1200W\n\t5 - ASUS ROG Strix Aura Edition 1000W\n\t6 - ASUS ROG Thor 1600W");
                        //int psuChoice = Convert.ToInt32(Console.ReadLine().Trim());
                        string power = Console.ReadLine().Trim();
                        if (power == "1")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "Aerocool KCAS Plus", Cost = 5799, Capacity = "1200W", Certificate = "80+ Gold" });
                        }
                        else if (power == "2")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "Chieftec Polaris", Cost = 5529, Capacity = "850W", Certificate = "80+ Gold" });
                        }
                        else if (power == "3")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "Be Quiet! Straight Power 11 Platinum", Cost = 8369, Capacity = "850W", Certificate = "80+ Platinum" });
                        }
                        else if (power == "4")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "NZXT C Series", Cost = 10999, Capacity = "1200W", Certificate = "80+ Gold" });
                        }
                        else if (power == "5")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "ASUS ROG Strix Aura Edition", Cost = 11045, Capacity = "1000W", Certificate = "80+ Gold" });
                        }
                        else if (power == "6")
                        {
                            userComputer.Motherboard.Power.Add(new PowerSupply { Name = "ASUS ROG Thor", Cost = 32345, Capacity = "1600W", Certificate = "80+ Titanium" });
                        }
                        else
                        {
                            Console.WriteLine($"Помилка введення.");
                            return;
                        }
                        break;
                    case "0":
                        isWork = false;
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір збірки.");
                        break;
                }

                Console.WriteLine($"\nВаше замовлення:\n");

                Console.WriteLine($"CPU: {userComputer.Motherboard.CpuSlots[0].Name}, {userComputer.Motherboard.CpuSlots[0].Cores} Cores, {userComputer.Motherboard.CpuSlots[0].Frequency} GHz - {userComputer.Motherboard.CpuSlots[0].Cost} грн");
                Console.WriteLine($"GPU: {userComputer.Motherboard.GpuSlots[0].Name}, {userComputer.Motherboard.GpuSlots[0].Memory} GB, {userComputer.Motherboard.GpuSlots[0].MemoryType} - {userComputer.Motherboard.GpuSlots[0].Cost} грн");
                Console.WriteLine($"RAM: {userComputer.Motherboard.RamSlots[0].Name}, {userComputer.Motherboard.RamSlots[0].Amount} GB, {userComputer.Motherboard.RamSlots[0].Type} - {userComputer.Motherboard.RamSlots[0].Cost} грн");
                Console.WriteLine($"SSD: {userComputer.Motherboard.SsdSlots[0].Name}, {userComputer.Motherboard.SsdSlots[0].Capacity}, {userComputer.Motherboard.SsdSlots[0].Speed} Mb/s - {userComputer.Motherboard.SsdSlots[0].Cost} грн");
                Console.WriteLine($"PowerSupply: {userComputer.Motherboard.Power[0].Name}, {userComputer.Motherboard.Power[0].Capacity}, {userComputer.Motherboard.Power[0].Certificate} - {userComputer.Motherboard.Power[0].Cost} грн");
                Console.WriteLine($"Всього: {userComputer.Motherboard.CpuSlots[0].Cost + userComputer.Motherboard.GpuSlots[0].Cost + userComputer.Motherboard.RamSlots[0].Cost + userComputer.Motherboard.SsdSlots[0].Cost + userComputer.Motherboard.Power[0].Cost} грн");

                Console.WriteLine($"\n{new string('=', 20)}\n");
            }

        }
    }
}
