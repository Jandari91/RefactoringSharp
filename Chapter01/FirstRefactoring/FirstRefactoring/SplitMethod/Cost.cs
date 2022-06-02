using Newtonsoft.Json;
using System.Collections.Immutable;


namespace FirstRefactoring.SplitMethod;

public class Cost
{

    public Cost()
    {
        
        var invoice = JsonConvert.DeserializeObject<Invoice>(ReadJsonFile("SplitMethod/invoices.json"));
        var plays = JsonConvert.DeserializeObject<IImmutableDictionary<string, Play>>(ReadJsonFile("SplitMethod/plays.json"));
    }

    public string Statement(Invoice invoice, IImmutableDictionary<string, Play> plays)
    {
        return "";
    }

    private string ReadJsonFile(string filePath)
    {
        StreamReader r = new StreamReader(filePath);
        string jsonString = r.ReadToEnd();
        return jsonString;
    }
}


public class Play
{
    public string Name { get; }
    public string Type { get; }

    public Play(string name, string payType)
    {
        Name = name;
        Type = payType;
    }
}

public class Performance
{
    public  int Audience { get; }
    public  string PlayId { get; }

    public Performance(string playId, int audience)
    {
        PlayId = playId;
        Audience = audience;
    }
}

public class Invoice
{
    public string Customer { get; }
    public ImmutableList<Performance> Performances { get; }
        
    public Invoice(string customer, ImmutableList<Performance> performances)
    {
        Customer = customer;
        Performances = performances;
    }
}
