namespace msdev.Interface
{
    public interface iJogador
    {
        //A Interface é um contrato, ou seja, todo cara que quiser ser um jogador
        //Deverá implementar esta interface
         string Corre();
         string Chuta();
         string Passe();
    }
}