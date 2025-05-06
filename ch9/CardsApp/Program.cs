using System;

class Program
{
    static void Main()
    {
        // 建立 PhoneList 物件
        PhoneList phoneList = new PhoneList(
            homePhone: "123-456-7890",
            businessPhone: "098-765-4321",
            cellPhone: "555-123-4567"
        );

        // 建立 Cards 物件
        Cards card = new Cards(
            name: "Jane Smith",
            occupation: "Graphic Designer",
            age: 28,
            phone: phoneList,
            email: "janesmith@example.com"
        );

        // 顯示名片資料
        Console.WriteLine("Card Information:");
        Console.WriteLine(card.GetCard());
    }
}