
//Student ID : 1690700081
//Name       : kiart losatcha
//Section    : 129A
//No.        :
//Course     : GI113 Computer Programming (GI113)

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 1. CONST (PascalCase) 
            // ค่าคงที่ที่ไม่เปลี่ยนตลอดการทำงาน (ชื่อเกม)
            // ==========================================
            const string GameTitle = "DELTA FORCE: HAWK OPS";

            // ==========================================
            // 2. VAR (camelCase)
            // ใช้ var ให้ Compiler เดาชนิดข้อมูล string และ char
            // ==========================================
            var operatorName = "Vyron";          // ชนิด string: โค้ดเนมโอเปอเรเตอร์
            var tacticalClass = 'A';             // ชนิด char: อักษรย่อสายการรบ (Assault)

            // ==========================================
            // 3. PRIMITIVE DATA TYPES (6 ชนิดข้อมูลพื้นฐาน)
            // ==========================================
            string activeOperation = "HAZARD OPERATIONS";     // string: โหมดการเล่น
            char weaponAmmoGrade = 'G';                       // char: เกรดกระสุน (Gold Grade 6.8x51mm)
            int stashValueCoins = 12500000;                   // int: มูลค่าทรัพย์สินในคลัง (Tekniq Coins)
            float operatorMovementSpeed = 8.45f;              // float: ความเร็วการเคลื่อนที่ (m/s)
            double gunEffectiveRange = 85.75;                 // double: ระยะยิงหวังผล (Meters)
            bool isDynamicPropulsionReady = true;             // bool: สถานะสกิลแดชพุ่งตัว

            // ข้อมูลเพิ่มเติมสำหรับจัดแสดงใน UI
            int m7FireRateRpm = 650;                          // อัตราการยิง (RPM)
            double m7MarketValue = 428500.85;                 // ราคาปืนในตลาด ( double เลขหลังจุด >= .5 )

            // ==========================================
            // 4. DISPLAY OUTPUT (GAME MENU & HUD UI)
            // จัดกรอบขนาดความกว้าง 75 ช่องอักขระให้ตรงเป๊ะทุกบรรทัด
            // ==========================================
            Console.WriteLine("===========================================================================");
            Console.WriteLine("  ___  ____ _    _____  _    ____  ____ ____  ____ ____ ");
            Console.WriteLine("  |  \\ |___ |    |  |  / \\   |___  |  | |__/  |    |___ ");
            Console.WriteLine("  |__/ |___ |___ |  | /   \\  |     |__| |  \\  |___ |___ ");
            Console.WriteLine($"  [{GameTitle} - MAIN MENU UI]                  ");
            Console.WriteLine("===========================================================================");
            Console.WriteLine(" |                                                                       |");
            Console.WriteLine(" |  [DEPLOYMENT MODE] -> HAZARD OPERATIONS                               |");
            Console.WriteLine(" |                                                                       |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |  |  OPERATOR PROFILE                                               |  |");
            Console.WriteLine($" |  |  >> CODENAME      : {operatorName,-43} |  |");
            Console.WriteLine($" |  |  >> CLASS ROLE    : [{tacticalClass}] ASSAULT SPECIALIST                      |  |");
            Console.WriteLine($" |  |  >> ACTIVE ZONE   : {activeOperation,-43} |  |");
            Console.WriteLine(" |  |  >> SIGNATURE     : Dynamic Propulsion (Dash)                   |  |");
            Console.WriteLine($" |  |  >> SKILL STATUS  : {(isDynamicPropulsionReady ? "[READY TO DEPLOY]" : "[COOLING DOWN]"),-43} |  |");
            Console.WriteLine($" |  |  >> SPRINT SPEED  : {operatorMovementSpeed,-5} m/s                                   |  |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |                                                                       |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |  |  PRIMARY LOADOUT: M7 BATTLE RIFLE                               |  |");
            Console.WriteLine($" |  |  >> AMMO TIER     : Class-{weaponAmmoGrade} Armor Piercing (6.8x51mm)           |  |");
            Console.WriteLine($" |  |  >> RATE OF FIRE  : {m7FireRateRpm,-5} RPM                                   |  |");
            Console.WriteLine($" |  |  >> EFFECT RANGE  : {gunEffectiveRange,-5} Meters                                |  |");
            Console.WriteLine($" |  |  >> MARKET VALUE  : ${m7MarketValue:N2} Tekniq Coins                    |  |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |                                                                       |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |  |  EXTRACTION ECONOMY                                             |  |");
            Console.WriteLine($" |  |  >> TOTAL STASH   : {stashValueCoins:N0} Tekniq Coins                     |  |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+  |");
            Console.WriteLine(" |                                                                       |");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("  [ F1 ] EDIT LOADOUT   |   [ F2 ] STASH   |   [ SPACE ] MATCHMAKING       ");
            Console.WriteLine("===========================================================================");
            Console.WriteLine();

            // ==========================================
            // 5. IMPLICIT CONVERSION
            // แปลงค่า int -> double โดยไม่ใช้ Cast
            // ==========================================
            double m7FireRateAsDouble = m7FireRateRpm;
            Console.WriteLine($" [SYSTEM LOG] Implicit Conversion (RPM int -> double) : {m7FireRateAsDouble}");

            // ==========================================
            // 6. EXPLICIT CAST vs CONVERT.TOINT32()
            // แสดงความต่างของการแปลง double (ราคาปืน 428500.85) เป็น int
            // ==========================================
            // (int) จะตัดเศษทศนิยมทิ้งทันที -> ได้ 428500
            int castMarketValue = (int)m7MarketValue;

            // Convert.ToInt32() ปัดเศษขึ้นตามหลักคณิตศาสตร์ -> ได้ 428501
            int convertMarketValue = Convert.ToInt32(m7MarketValue);

            Console.WriteLine($" [SYSTEM LOG] Raw Market Value Double                 : {m7MarketValue}");
            Console.WriteLine($" [SYSTEM LOG] Explicit Cast (int)     [Truncated]    : {castMarketValue}");
            Console.WriteLine($" [SYSTEM LOG] Convert.ToInt32()       [Rounded Up]   : {convertMarketValue}");
            Console.WriteLine("===========================================================================");
        }
    }
}