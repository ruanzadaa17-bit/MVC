using System.ComponentModel.DataAnnotations;

namespace CadastroClientes;

public class Cliente
{
    
    public int Id {get; set;}

    [Required] //campo obrigatório
    [StringLength(100)] // tamanho máximo do texto em caracter
    public string Nome {get; set;}

    [StringLength(14)]
    public string? CPF {get; set;}  // ? = aceita nulo
    [EmailAddress]
    [StringLength(150)]
    public string? Email {get; set;}
    [Phone]
    [StringLength(20)]
    public string? Telefone {get; set;}
    [StringLength(100)]
    public string? Endereco {get; set;}
    [StringLength(100)]
    public string? Cidade {get; set;}
    [StringLength(2)]
    public string? UF {get; set;}
    [DataType(DataType.Date)] // identifica que o campo é data e mostra somente DATA
    [Display(Name = "Data de nascimento")] // mostra o campo ao usuário de 
    public DateTime DataNascimento {get; set;}
    public bool Ativo {get; set;} = true;
}
