namespace SistemaConsolePacientes
{
    class Paciente
    {
        private string nome;
        private int cod_chegada;
        private int idade;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Cod_Chegada
        {
            get
            {
                return cod_chegada;
            }

            set
            {
                cod_chegada = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }
    }
}
