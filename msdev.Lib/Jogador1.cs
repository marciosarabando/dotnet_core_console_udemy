using msdev.Interface;

namespace msdev.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }
        
        //corre
        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }

        //passe
        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }


    }
}