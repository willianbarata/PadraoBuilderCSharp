﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Builder
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;
        public Veiculo Veiculo
        {
            get { return _veiculo; }
        }

        //processo de construção (Abstrato)
        public abstract void BuildMotor();
        public abstract void BuildPortas();
        public abstract void BuildPneus();
    }
}
