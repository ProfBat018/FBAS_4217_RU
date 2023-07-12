namespace CoreFirst.Models;

// 20230710164737
// https://cat-fact.herokuapp.com/facts
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Result
{
    public Status status { get; set; }
    public string _id { get; set; }
    public string user { get; set; }
    public string text { get; set; }
    public int __v { get; set; }
    public string source { get; set; }
    public DateTime updatedAt { get; set; }
    public string type { get; set; }
    public DateTime createdAt { get; set; }
    public bool deleted { get; set; }
    public bool used { get; set; }
}

public class CatsFacts
{
    public List<Result> results { get; set; }
}

public class Status
{
    public bool verified { get; set; }
    public int sentCount { get; set; }
}


