namespace ClassPersona
{
    public class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
        public string getNome() { return nome; }
        public string getCognome() { return cognome; }
        public int getEta() { return eta; }
        public string getDettagli()
        {
            return "nome: " + nome + "\tcognome: " + cognome + "\tetà: " + eta + " anni";
        }
    }

}