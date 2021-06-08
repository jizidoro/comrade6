#region

using System;
using System.Threading.Tasks;
using Comrade.Core.AirplaneCore.Validation;
using Comrade.Core.Helpers.Bases;
using Comrade.Core.Helpers.Interfaces;
using Comrade.Core.Helpers.Messages;
using Comrade.Core.Helpers.Models.Results;
using Comrade.Domain.Models;

#endregion

namespace Comrade.Core.AirplaneCore.Usecase
{
    public class AirplaneIncluirUsecase : Service
    {
        private readonly AirplaneValidarIncluir _airplaneValidarIncluir;
        private readonly IAirplaneRepository _repository;

        public AirplaneIncluirUsecase(IAirplaneRepository repository, AirplaneValidarIncluir airplaneValidarIncluir,
            IUnitOfWork uow)
            : base(uow)
        {
            _repository = repository;
            _airplaneValidarIncluir = airplaneValidarIncluir;
        }

        public async Task<ISingleResult<Airplane>> Execute(Airplane entity)
        {
            try
            {
                var isValid = ValidarEntidade(entity);
                if (!isValid.Sucesso)
                {
                    return isValid;
                }

                var validacao = await _airplaneValidarIncluir.Execute(entity);
                if (!validacao.Sucesso) return validacao;
                entity.DataRegistro = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
                    TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
                await _repository.Add(entity);

                var sucesso = await Commit();
            }
            catch (Exception)
            {
                return new SingleResult<Airplane>(MensagensNegocio.MSG07);
            }

            return new IncluirResult<Airplane>(entity);
        }
    }
}