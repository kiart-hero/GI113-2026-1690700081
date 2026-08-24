# GI113-2026-<your-student-id>

Repository ส่วนตัวของวิชา **GI113 Computer Programming (GI)** ภาคเรียนที่ 1/2569 — ใช้ repo นี้ตลอดทั้งเทอมสำหรับส่งงาน Lab ทุกสัปดาห์

## ข้อมูลนักศึกษา

**วิธีกรอก**: เปิดไฟล์นี้บน GitHub.com → กดไอคอนดินสอ (Edit this file) มุมขวาบน → พิมพ์ข้อมูลต่อท้ายเครื่องหมาย `:` ในแต่ละบรรทัดด้านล่าง (ห้ามลบเครื่องหมาย `:` หรือแก้คำด้านหน้า) → เลื่อนลงล่างสุดกด **Commit changes**

```
ชื่อ-นามสกุล: 
Section: 
รหัสนักศึกษา: 
เลขที่: 
```

## กติกาการตั้งชื่อ (Naming Convention)

อักขระที่ใช้ได้: `a-z`, `A-Z`, `0-9`, `_` เท่านั้น — ห้ามเว้นวรรค ห้ามภาษาไทย ห้ามขึ้นต้นด้วยตัวเลข

| รูปแบบ | ตัวอย่าง | ใช้กับ |
|---|---|---|
| PascalCase | `Lab02`, `BossBattle` | ชื่อ Solution / Project / class / method / public member |
| camelCase | `currentHp` | local variable, parameter |
| _underscore นำหน้า | `_maxHp` | private / internal field |

**สคริปต์ตรวจงานเช็คชื่อ Solution/Project ว่าเป็น PascalCase — ตั้งชื่อผิดรูปแบบจะถูกหักคะแนนแม้โค้ดถูก**

## โครงสร้างที่ต้องทำในทุก Lab

```
GI113-2026-<your-student-id>/
└── LabNN/              ← โฟลเดอร์ชื่อ LabNN (เลขสองหลัก เช่น Lab02, Lab03)
    ├── LabNN.sln
    └── LabNN/
        └── Program.cs  ← ใส่ HEADER-TEMPLATE.txt ไว้บรรทัดบนสุดเสมอ
```

ขั้นตอนสร้างโปรเจกต์ใหม่ทุกครั้ง (สรุปจากที่สอนในคาบ):

1. Clone repository นี้มาที่เครื่อง (GitHub Desktop → File → Clone repository)
2. เปิด Visual Studio 2026 → New Project → Console App (C#)
3. Location = โฟลเดอร์ที่ clone มา, ตั้งชื่อโปรเจกต์เป็น `LabNN` (ตรงกับเลข Lab)
4. **ติ๊ก "Place solution and project in the same directory" ก่อนกด Create** — ถ้าไม่ติ๊ก จะได้ `LabNN\LabNN\Program.cs` ซ้อนสองชั้น สคริปต์ตรวจงานหาไม่เจอ
5. คัดลอกเนื้อหาจาก `HEADER-TEMPLATE.txt` วางไว้บรรทัดบนสุดของ `Program.cs`
6. เขียนโค้ดตามโจทย์ Lab
7. Commit ด้วยข้อความที่สื่อความหมายจริง (ไม่ใช่ `"update"`) แล้ว Push ขึ้น repo นี้
8. วางลิงก์ commit ใน Teams ตามที่กำหนดในแต่ละ Lab — ลิงก์นี้คือสิ่งที่ใช้ตรวจ

## ไฟล์ในนี้

- `README.md` — ไฟล์นี้
- `HEADER-TEMPLATE.txt` — comment block สำหรับวางบนสุดของ `Program.cs` ทุกไฟล์
- `.gitignore` — ไม่ track ไฟล์ build ของ .NET และ Unity
