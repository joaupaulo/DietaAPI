﻿using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
    interface AlimentosInterface
    {
        List<Alimento> ListarTodos();
        Alimento BuscarItem(Alimento Alimentos);
        Alimento Create(Alimento Alimentos);
        Alimento Update(Alimento Alimentos);
        Alimento Delete(Alimento Alimentos);

    }
}