namespace DesafioPOO.Helpers;

public static class AttributesHelper
{
    public static string GenerateIMEI()
    {
        var imei = string.Empty;
        var random = new Random();
        for (int i = 0; i < 15; i++)
        {
            imei += random.Next(0, 9).ToString();
        }

        return imei;
    }

    public static int GenerateMemory(int minGbValue = 32, int MaxGbValue = 1024)
    {
        var random = new Random();
        //Generate a memory size in kb
        var memory = random.Next(minValue: minGbValue, maxValue: MaxGbValue) * 1024 * 1024;
        return memory;
    }
    
}