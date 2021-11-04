using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCamadasPOO.Code.DTO
{
    class HortaDTO
    {

        //Propriedades
        private int _id;
        private int _quantidade;
        private string _plantanome;
        private double _preco;
        
        //Encapsulamento
        public int Id { get => _id; set => _id = value; }
        public string Plantanome { get => _plantanome; set => _plantanome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
       
    }
}
