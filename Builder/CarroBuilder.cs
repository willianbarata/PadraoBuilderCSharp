﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro Passeio");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "127c";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "4";
        }
    }
}
