#region

using Comrade.Application.Dtos.UsuarioSistemaDtos;

#endregion

namespace Comrade.Application.Validations.BaUsuValitation
{
    public class UsuarioSistemaEditarValidation : UsuarioSistemaValidation<UsuarioSistemaEditarDto>
    {
        public UsuarioSistemaEditarValidation()
        {
            ValidarId();
            ValidarNome();
            ValidarEmail();
            ValidarSenha();
            ValidarMatricula();
        }
    }
}