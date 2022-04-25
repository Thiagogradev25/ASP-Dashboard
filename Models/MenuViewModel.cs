namespace ASP_Dashboard.Models;

public class MenuViewModel
{
    public int id { get; set; }

    public string descricao { get; set; }

    public int ordem { get; set; }

    public bool inativo { get; set; }
    public bool acesspadm { get; set; }
}
