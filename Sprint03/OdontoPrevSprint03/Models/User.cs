namespace OdontoPrevSprint03.Models
{
    /// <summary>
    /// Representa um usuário (paciente) no sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador único do usuário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do usuário.
        /// </summary>
        public string? Nome { get; set; }
        /// <summary>
        /// Data de aniversário do usuário.
        /// </summary>
        public DateTime DataAniversario { get; set; }


        /// <summary>
        /// Endereço de e-mail do usuário.
        /// </summary>
        public string? Email { get; set; }
    }
}
