﻿using System;
using msdev.Lib;

namespace msdev
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador2(), new Jogador1("Marcio"));
            jogo.IniciarJogo();
        }
    }

}
