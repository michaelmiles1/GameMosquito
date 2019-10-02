using System;
using System.Collections.Generic;
using GameMosquito.Models;

namespace GameMosquito.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
