using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioForms
{
    public class Jokenpo
    {
        private int vencedor;
        private JokenpoEnum jokenpo;


        public Jokenpo(int vencedor, JokenpoEnum jokenpo)
        {
            this.vencedor = vencedor;
            this.jokenpo = jokenpo;

        }
        public Jokenpo() { }

        public int Vencedor { get { return vencedor; } set { vencedor = value; } }

        public JokenpoEnum JokenpoEnumJokenpo { get { return jokenpo; } set { jokenpo = value; } }

        public int GetValue(JokenpoEnum j1)
        {
            switch (j1)
            {
                case JokenpoEnum.Pedra:
                    return 0;
                case JokenpoEnum.Papel:
                    return 1;
                case JokenpoEnum.Tesoura:
                    return 2;

                default: throw new NotImplementedException();
            }
        }

        public string retornaGanhador(JokenpoEnum j1, JokenpoEnum j2)
        {
            int jogador1 = GetValue(j1);
            int jogador2 = GetValue(j2);
            string resposta = "";

            if (0 <= jogador1 && jogador1 <= 2 && 0 <= jogador2 && jogador2 <= 2)
            {
                if (jogador1 == jogador2)
                {
                    resposta = "Empate! Ninguém ganhou.";
                }
                else if (jogador1 - jogador2 == -2 || jogador1 - jogador2 == 1)
                {
                    resposta = "Jogador 1 ganhou.";
                }
                else
                {
                    resposta = "Jogador 2 ganhou.";
                }
            }
            return resposta;
        }

        public JokenpoEnum getEnumByString(String name)
        {
            switch (name)
            {
                case "Pedra":
                    return JokenpoEnum.Pedra;
                case "Papel":
                    return JokenpoEnum.Papel;
                case "Tesoura":
                    return JokenpoEnum.Tesoura;
                default: throw new NotImplementedException();
            }
        }

        public String getStringByEnum(JokenpoEnum j)
        {
            switch (j)
            {
                case JokenpoEnum.Pedra:
                    return "Pedra";
                case JokenpoEnum.Papel:
                    return "Papel";
                case JokenpoEnum.Tesoura:
                    return "Tesoura";
                default: throw new NotImplementedException();
            }
        }
    }
}