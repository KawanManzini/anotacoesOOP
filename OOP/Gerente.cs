﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Gerente : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 1000;
        }
    }
}
