public class FeatureCollection
{
    public string Type { get; set; } = "";
    public Feature[] Features { get; set; } = new Feature[0];
}

public class Feature
{
    public string Type { get; set; } = "";
    public Properties Properties { get; set; } = new Properties();
    public Geometry Geometry { get; set; } = new Geometry();
}

public class Properties
{
    public decimal? Mag { get; set; }
    public string? Place { get; set; }
    public object? Type { get; set; }
    public object? Title { get; set; }
    public object? Time { get; set; }
    public object? Updated { get; set; }
    public object? Url { get; set; }
    public object? Detail { get; set; }
    public object? Felt { get; set; }
    public object? Cdi { get; set; }
    public object? Mmi { get; set; }
    public object? Alert { get; set; }
    public object? Status { get; set; }
    public object? Tsunami { get; set; }
    public object? Sig { get; set; }
    public object? Net { get; set; }
    public object? Code { get; set; }
    public object? Ids { get; set; }
    public object? Sources { get; set; }
    public object? Types { get; set; }
    public object? Nst { get; set; }
    public object? Dmin { get; set; }
    public object? Rms { get; set; }
    public object? Gap { get; set; }
    public object? MagType { get; set; }
}

public class Geometry
{
    public string Type { get; set; } = "";
    public decimal[] Coordinates { get; set; } = new decimal[0];
}