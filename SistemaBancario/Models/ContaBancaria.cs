namespace SistemaBancario.Models
{
    //Pilar: Abstração
    public abstract class ContaBancaria
    {

        //Pilar: Encapsulamento: Campos Privados protegidos por propriedades publicas

        private string _numeroConta;

        private decimal _saldo;

        //Existem 3 tipos de modifcadores:
        //primeiro: public - todos acessam
        //segundo: private - somente a classe acessa
        //terceiro: protected - somente classe filhas acessam
        //Propriedades
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }
        public List<string>ExtratoTransacoes { get; set; } = new List<string>();

        //Construtor da classe base
        protected ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta Criada com saldo inical de : R$ {saldoInicial:F2}");
        }
    }
}
