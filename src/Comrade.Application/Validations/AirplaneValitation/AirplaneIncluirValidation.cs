﻿#region

using Comrade.Application.Dtos.AirplaneDtos;

#endregion

namespace Comrade.Application.Validations.AirplaneValitation
{
    public class AirplaneIncluirValidation : AirplaneValidation<AirplaneIncluirDto>
    {
        public AirplaneIncluirValidation()
        {
            ValidarCodigo();
            ValidarModelo();
            ValidarQuantidadePassageiro();
        }
    }
}