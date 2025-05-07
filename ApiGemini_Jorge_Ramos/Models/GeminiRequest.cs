using System.Text.Json.Serialization;
using System.Collections.Generic;

public class GeminiRequest
{
    public List<Content> Contents { get; set; }
}

public class Content
{

    public List<Part> Parts { get; set; }
}

public class Part
{
    public string Text { get; set; }
}

