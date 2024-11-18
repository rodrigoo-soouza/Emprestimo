using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sistema_de_Emprestimos.Models;

public class Emprestimo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do aluno é obrigatório.")]
    [DisplayName("Nome do Aluno")]
    [StringLength(100, ErrorMessage = "O nome do aluno não pode ter mais de 100 caracteres.")]
    public string Aluno { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nome do funcionário é obrigatório.")]
    [DisplayName("Nome do Funcionário")]
    [StringLength(100, ErrorMessage = "O nome do funcionário não pode ter mais de 100 caracteres.")]
    public string Funcionario { get; set; } = string.Empty;

    [Required(ErrorMessage = "O cargo do funcionário é obrigatório.")]
    [DisplayName("Cargo do Funcionário")]
    [StringLength(50, ErrorMessage = "O cargo do funcionário não pode ter mais de 50 caracteres.")]
    public string CargoFuncionario { get; set; } = string.Empty;

    [Required(ErrorMessage = "O título do livro emprestado é obrigatório.")]
    [DisplayName("Título do Livro")]
    [StringLength(200, ErrorMessage = "O título do livro não pode ter mais de 200 caracteres.")]
    public string LivroEmprestado { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data de publicação do livro é obrigatória.")]
    [DisplayName("Data de Publicação do Livro")]
    [DataType(DataType.Date)]
    public DateTime DataPublicacaoLivro { get; set; }

    [Required(ErrorMessage = "A data da última atualização é obrigatória.")]
    [DisplayName("Data da Última Atualização")]
    public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

}




