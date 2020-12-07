﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aluguer> Alugueres { get; set; }
        public virtual ICollection<HistoricoRecursos> HistoricoRecursos { get; set; }
    }
}
