﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raposa.Lanches.DataBase
{
    public class Ingrediente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public virtual ICollection<LancheIngrediente> LancheIngredientes { get; set; }
    }
}
