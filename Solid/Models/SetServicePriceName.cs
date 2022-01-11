using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Models
{
    public class SetServicePriceName : ISetServicePriceName
    {
        public void SetPrices(IStandardService standardService, IWash wash, IClawCutting clawCutting)
        {
            standardService.Price = 400;
            wash.Price = 100;
            clawCutting.Price = 200;
        }

        public void SetName(IStandardService standardService, IWash wash, IClawCutting clawCutting)
        {
            standardService.Name = "Dagpassning";
            wash.Name = "Tvätt";
            clawCutting.Name = "Kloklippning";
        }

    }
}
