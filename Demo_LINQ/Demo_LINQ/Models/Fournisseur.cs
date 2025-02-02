﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_LINQ.Models
{
    public partial class Fournisseur
    {
        public string NumFourniture { get; set; }
        public string NameFournisseur { get; set; }
        public string Ville { get; set; }

        public override string ToString()
        {
            return $"NumFourniture: {this.NumFourniture}, NameFournisseur: {this.NameFournisseur}, Ville: {this.Ville}";
        }
    }
}
