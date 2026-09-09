using System;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // กำหนดค่าตัวแปรเริ่มต้นตามตัวอย่างในภาพ
            string name = "KIRIN";
            char rank = 'S';
            int level = 7;
            int maxLevel = 10;
            int currentHp = 115;
            int maxHp = 240;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // 1. พิมพ์หัวข้อและแสดงค่าตัวแปรทั้ง 7 บรรทัด
            Console.WriteLine("====== KIRIN SAVE CONVERTER ======");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {maxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            // บรรทัดว่างที่ 1
            Console.WriteLine();

            // 2. Implicit Conversion: HP as double
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // บรรทัดว่างที่ 2
            Console.WriteLine();

            // 3. Exact HP Percent
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            // บรรทัดว่างที่ 3
            Console.WriteLine();

            // 4. Explicit Cast: Attack Power -> Display Int
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // บรรทัดว่างที่ 4
            Console.WriteLine();

            // 5. Cast vs Convert: Crit Multiplier
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}