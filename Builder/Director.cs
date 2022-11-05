using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Director
    public class Director
    {
        public void Contruct(VeiculoBuilder builder)
        {
            builder.BuildMotor();
            builder.BuildPortas();
            builder.BuildPneus();
        }
    }
}
