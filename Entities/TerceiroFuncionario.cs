

namespace Teste.Entities
{
    class TerceiroFuncionario : Funcionario
    {
        public double CargaAdicional { get; set; }

        public TerceiroFuncionario()
        {

        }

        public TerceiroFuncionario(string nome, int horas, double valorPorHora, double cargaAdicional) 
            : base(nome,horas,valorPorHora)
        {
            CargaAdicional = cargaAdicional;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * CargaAdicional;
        }
    }
}
