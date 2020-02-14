using msdev.Interface;

namespace msdev.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
           return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Mardona estas passando \n";
        }
    }
}