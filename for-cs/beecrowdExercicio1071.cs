/* Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles. */

﻿using System;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int min, max;
            int soma = 0;

            if (x < y) {
                min = x;
                max = y;
            }
            else {
                min = y;
                max = x;
            }

            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
