using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Dashboard.Models;


[Table("viewGer_Menu")]
public class ItemMenuViewModel
{
    [Key]
    [Column("GER_Rotina_Id")]
    [Display(Name = "Rotina ID")]
    public int RotinaID { get; set; }


    [Required]
    [Column("titulo")]
    [Display(Name = "Titulo")]
    public string titulo { get; set; }


    [Column("GER_Menu_ID")]
    [Display(Name = "Menu ID")]
    public int Menuid { get; set; }


    [Column("DescMenu")]
    [Display(Name = "Tipo")]
    public string DescMenu { get; set; }


    [Column("acesspadm")]
    [Display(Name = "Tipo de Acesso")]
    public bool acesspadm { get; set; }

    [Column("OrdemMenu")]
    [Display(Name = "OrdemMenu")]
    public int OrdemMenu { get; set; }

    [Column("DescRotina")]
    [Display(Name = "Rotina")]
    public string DescRotina { get; set; }

    [Column("icone")]
    [Display(Name = "Icone")]
    public string Icone { get; set; }


    [Column("janela")]
    [Display(Name = "Janela")]
    public string Janela { get; set; }


    [Required]
    [Column("descricao")]
    [Display(Name = "Descrição")]
    public string descricao { get; set; }

    [Column("rota")]
    [Display(Name = "Rota")]
    public string Rota { get; set; }

    [Column("paramauxiliar")]
    [Display(Name = "Parametro Auxiliar")]
    public string Auxiliar { get; set; }

    [Column("OrdemRotina")]
    [Display(Name = "Ordem Rotina")]
    public int OrdemRotina { get; set; }

    [Column("Action")]
    [NotMapped]
    public string Action { get; set; }


    //Mapear demais campos da View "viewGer_Menu"




}
