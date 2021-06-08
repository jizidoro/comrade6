#region

using Comrade.Application.Dtos.UsuarioSistemaDtos;

#endregion

namespace Comrade.Application.Validations.BaUsuValitation
{
    public class UsuarioSistemaExcluirValidation : UsuarioSistemaValidation<UsuarioSistemaDto>
    {
        public UsuarioSistemaExcluirValidation()
        {
            ValidarId();
        }
    }
}