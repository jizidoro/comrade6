﻿#region

using Comrade.Core.Helpers.Messages;
using Comrade.Domain.Bases;
using Comrade.Domain.Enums;

#endregion

namespace Comrade.Core.Helpers.Models.Results
{
    public class IncluirResult<TEntity> : SingleResult<TEntity>
        where TEntity : Entity
    {
        public IncluirResult(TEntity data)
        {
            Codigo = (int) EnumResultadoAcao.Sucesso;
            Sucesso = true;
            Mensagem = MensagensNegocio.ResourceManager.GetString("MSG01");
            Data = data;
        }

        public IncluirResult(bool sucesso, string mensagem)
        {
            Codigo = sucesso ? (int) EnumResultadoAcao.Sucesso : (int) EnumResultadoAcao.ErroNaoEncontrado;
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public IncluirResult(string mensagem)
        {
            Codigo = (int) EnumResultadoAcao.ErroNaoEncontrado;
            Sucesso = false;
            Mensagem = mensagem;
        }
    }
}