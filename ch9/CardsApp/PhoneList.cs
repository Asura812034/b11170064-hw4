public class PhoneList
{
    // 成員變數
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    // 建構子
    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }

    // 格式化電話資訊
    public override string ToString()
    {
        return $"Home: {HomePhone}, Business: {BusinessPhone}, Cell: {CellPhone}";
    }
}