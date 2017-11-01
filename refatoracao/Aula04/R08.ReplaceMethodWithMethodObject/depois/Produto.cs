using System;

namespace refatoracao.R08.ReplaceMethodWithMethodObject.depois
{
    class Produto
    {
        private readonly string descricao;
        private bool promocional;
        private readonly double precoBase;
        private readonly double acrescimo;
        private readonly double desconto;

        public string Descricao { get => descricao; }
        public bool Promocional { get => promocional; }
        public double PrecoBase { get => precoBase; }
        public double Acrescimo { get => acrescimo; }
        public double Desconto { get => desconto; }

        public Produto(string descricao, double precoBase, double acrescimo, double desconto)
        {
            this.descricao = descricao;
            this.precoBase = precoBase;
            this.acrescimo = acrescimo;
            this.desconto = desconto;

            var preco = Preco(precoBase, acrescimo, desconto);

            Console.WriteLine($"ANTES: O preço é {preco}");
        }

        double Preco(double precoBase, double acrescimo, double desconto)
        {
            var resultado = precoBase;

            if (acrescimo > 0 && desconto > 0)
            {
                throw new Exception("Produto não pode ter acréscimo e desconto ao mesmo tempo!");
            }

            if (desconto > 20)
            {
                desconto = 20;
            }

            if (acrescimo > 15)
            {
                acrescimo = 15;
            }

            return precoBase + precoBase * (acrescimo - desconto);
        }

        public void HabilitarPromocao()
        {
            if (desconto == 0)
            {
                this.promocional = true;
            }
            else
            {
                throw new Exception("Produto com desconto não pode ser transformado em produto promocional!");
            }
        }
    }
}
