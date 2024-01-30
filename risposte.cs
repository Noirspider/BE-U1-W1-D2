namespace ClassRisposte
{
    internal class Risposte
    {

        private string RispostaDomanda1;
        private string RispostaDomanda2;
        private string RispostaDomanda3;

        public Risposte(string RispostaDomanda1, string RispostaDomanda2, string RispostaDomanda3)
        {
            this.RispostaDomanda1 = RispostaDomanda1;
            this.RispostaDomanda2 = RispostaDomanda2;
            this.RispostaDomanda3 = RispostaDomanda3;
        }
        public string getRisposte()
        {
            return "1) " + RispostaDomanda1 + "\n2) " + RispostaDomanda2 + "\n3) " + RispostaDomanda3;
        }
    }

}
