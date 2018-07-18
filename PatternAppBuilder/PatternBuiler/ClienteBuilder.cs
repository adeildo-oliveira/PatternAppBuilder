namespace PatternAppBuilder.PatternBuiler
{
    public class ClienteBuilder
    {
        private string _nome;
        private string _sobreNome;
        private string _email;
        private string _telefone;
        private string _endereco;
        private int _numero;
        private string _complemento;

        public ClienteBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public ClienteBuilder ComSobreNome(string sobreNome)
        {
            _sobreNome = sobreNome;
            return this;
        }

        public ClienteBuilder ComEmail(string email)
        {
            _email = email;
            return this;
        }

        public ClienteBuilder ComTelefone(string telefone)
        {
            _telefone = telefone;
            return this;
        }

        public ClienteBuilder ComEndereco(string endereco)
        {
            _endereco = endereco;
            return this;
        }

        public ClienteBuilder ComNumero(int numero)
        {
            _numero = numero;
            return this;
        }

        public ClienteBuilder ComComplemento(string complemento)
        {
            _complemento = complemento;
            return this;
        }

        public Cliente ConstroiCliente() => 
            new Cliente(_nome, _sobreNome, _email, _telefone, _endereco, _numero, _complemento);
    }
}
