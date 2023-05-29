using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioForms
{
    public class Peso
    {
        private int pesoTerra;
        private PlanetaEnum planeta;

        public Peso(int pesoTerra, PlanetaEnum planeta)
        {
            this.pesoTerra = pesoTerra;
            this.planeta = planeta;
        }

        public Peso() { }

        public int PesoTerra { get { return pesoTerra; } set { pesoTerra = value; } }
        public PlanetaEnum Planeta { get { return planeta; } set { planeta = value; } }

        public double getPesoPlaneta(Peso peso) { 
            switch (peso.planeta)
            {
                case PlanetaEnum.Mercurio:
                    return peso.pesoTerra * 0.37;
                case PlanetaEnum.Venus:
                    return peso.pesoTerra * 0.88;
                case PlanetaEnum.Marte:
                    return peso.pesoTerra * 0.38;
                case PlanetaEnum.Jupiter:
                    return peso.pesoTerra * 2.64;
                case PlanetaEnum.Saturno:
                    return peso.pesoTerra * 1.15;
                case PlanetaEnum.Urano:
                    return peso.pesoTerra * 1.17;
                default: throw new NotImplementedException();
            }
        }

        public String getPlanetaName()
        {
            switch (this.planeta)
            {
                case PlanetaEnum.Mercurio:
                    return "Mercúrio";
                case PlanetaEnum.Venus:
                    return "Vênus";
                case PlanetaEnum.Marte:
                    return "Marte";
                case PlanetaEnum.Jupiter:
                    return "Júpiter";
                case PlanetaEnum.Saturno:
                    return "Saturno";
                case PlanetaEnum.Urano:
                    return "Urano";
                default: throw new NotImplementedException();
            }
        }

        public PlanetaEnum getEnumByString(String name)
        {
            switch (name)
            {
                case "Mercurio":
                    return PlanetaEnum.Mercurio;
                case "Venus":
                    return PlanetaEnum.Venus;
                case "Marte":
                    return PlanetaEnum.Marte;
                case "Jupiter":
                    return PlanetaEnum.Jupiter;
                case "Saturno":
                    return PlanetaEnum.Saturno;
                case "Urano":
                    return PlanetaEnum.Urano;
                default: throw new NotImplementedException();
            }
        }
    }


}
