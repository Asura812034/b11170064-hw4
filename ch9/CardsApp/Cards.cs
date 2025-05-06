public class Cards
{
    // 成員變數
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public PhoneList Phone { get; set; }
    public string Email { get; set; }

    // 建構子
    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    // 取得名片資料
    public string GetCard()
    {
        return $"Name: {Name}\n" +
               $"Occupation: {Occupation}\n" +
               $"Age: {Age}\n" +
               $"Phone: {Phone}\n" +
               $"Email: {Email}";
    }
}