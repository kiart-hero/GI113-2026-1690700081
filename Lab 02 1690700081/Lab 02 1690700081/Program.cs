/*
 * Student ID : 1690700081
 * Name       : kiart losatcha
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */




using static System.Net.Mime.MediaTypeNames;

namespace Lab002
{
    internal class Program
    {
        static void Main(string[] args)
        { //A past

            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"level: {level}");
            Console.WriteLine($"HP: {currentHp / maxHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");
            Console.WriteLine();
            Console.WriteLine();

            //B past
            
            // 1. ประกาศข้อมูลตัวละครทั้ง 4 ตัว

            // ตัวละครที่ 1: Fighter (นักรบ)
            string name1 = "Punching Jesus";
                string class1 = "Fighter";
                int level1 = 5;
                int maxHp1 = 250;
                int currentHp1 = 250;
                float attack1 = 25.5f;
                double crit1 = 1.35;
                bool isAlive1 = true;

                // ตัวละครที่ 2: wizard (จอมเวท)
                string name2 = "Gacha Caster";
                string class2 = "wizard";
                int level2 = 4;
                int maxHp2 = 150;
                int currentHp2 = 150;
                float attack2 = 40.0f;
                double crit2 = 1.20;
                bool isAlive2 = true;

                // ตัวละครที่ 3: Archer (นักธนู)
                string name3 = "Zero Accuracy";
                string class3 = "Archer";
                int level3 = 4;
                int maxHp3 = 180;
                int currentHp3 = 180;
                float attack3 = 30.0f;
                double crit3 = 1.50;
                bool isAlive3 = true;

                // ตัวละครที่ 4: Assassin (นักฆ่า)
                string name4 = "Shadow";
                string class4 = "Assassin";
                int level4 = 6;
                int maxHp4 = 160;
                int currentHp4 = 160;
                float attack4 = 35.0f;
                double crit4 = 2.00;
                bool isAlive4 = true;

                // 2. แสดงสถานะเริ่มต้นของทุกตัวละคร
                
                Console.WriteLine("================ INITIAL STATUS ================");
                PrintCharacterStatus(name1, class1, level1, currentHp1, maxHp1, attack1, crit1, isAlive1);
                PrintCharacterStatus(name2, class2, level2, currentHp2, maxHp2, attack2, crit2, isAlive2);
                PrintCharacterStatus(name3, class3, level3, currentHp3, maxHp3, attack3, crit3, isAlive3);
                PrintCharacterStatus(name4, class4, level4, currentHp4, maxHp4, attack4, crit4, isAlive4);

               
                // 3. จำลองการรับความเสียหาย (Damage Simulation)
               
                Console.WriteLine("\n================ BATTLE LOG ================");

                // Fighter รับความเสียหาย 60
                int damage1 = 60;
                currentHp1 -= damage1;
                Console.WriteLine($"{name1} takes {damage1} damage!");

                // wizard รับความเสียหาย 40
                int damage2 = 40;
                currentHp2 -= damage2;
                Console.WriteLine($"{name2} takes {damage2} damage!");

                // Archer รับความเสียหาย 90
                int damage3 = 90;
                currentHp3 -= damage3;
                Console.WriteLine($"{name3} takes {damage3} damage!");

                // Assassin รับความเสียหาย 160 (Hp เหลือ 0)
                int damage4 = 160;
                currentHp4 -= damage4;
                if (currentHp4 <= 0)
                {
                    currentHp4 = 0;
                    isAlive4 = false;
                }
                Console.WriteLine($"{name4} takes {damage4} damage!");

                // ==========================================
                // 4. แสดงสถานะหลังโดนความเสียหาย
                // ==========================================
                Console.WriteLine("================ STATUS AFTER DAMAGE ================");
                PrintCharacterStatus(name1, class1, level1, currentHp1, maxHp1, attack1, crit1, isAlive1);
                PrintCharacterStatus(name2, class2, level2, currentHp2, maxHp2, attack2, crit2, isAlive2);
                PrintCharacterStatus(name3, class3, level3, currentHp3, maxHp3, attack3, crit3, isAlive3);
                PrintCharacterStatus(name4, class4, level4, currentHp4, maxHp4, attack4, crit4, isAlive4);
            }

            // ฟังก์ชันช่วยพิมพ์ข้อมูลตัวละคร เพื่อลดโค้ดซ้ำซ้อน
            static void PrintCharacterStatus(string name, string className, int level, int currentHp, int maxHp, float attack, double crit, bool isAlive)
            {
                // คำนวณเปอร์เซ็นต์ HP (แปลงเป็น float)
                float hpPercentage = ((float)currentHp / maxHp) * 100;

                Console.WriteLine($"--- [{name}] ---");
                Console.WriteLine($"Class: {className} | Level: {level}");
                Console.WriteLine($"HP: {currentHp}/{maxHp} ({hpPercentage:F1}%)");
                Console.WriteLine($"Attack Power: {attack} | Crit Multiplier: {crit}");
                Console.WriteLine($"Is Alive: {isAlive}");
                Console.WriteLine();
            }
        }
    }
   
