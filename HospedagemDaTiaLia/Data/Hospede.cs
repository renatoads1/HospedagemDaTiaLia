namespace HospedagemDaTiaLia.Data
{
    class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Logadouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Empresa { get; set; }

        public Hospede()
        {
        }

        public Hospede(int id, string nome, string sobrenome, string dataNasc, string telefone, string celular, string rg, string cpf, string logadouro, string numero, string complemento, string bairro, string cidade, string estado, string empresa)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNasc = dataNasc;
            Telefone = telefone;
            Celular = celular;
            Rg = rg;
            Cpf = cpf;
            Logadouro = logadouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Empresa = empresa;
        }
    }
}
