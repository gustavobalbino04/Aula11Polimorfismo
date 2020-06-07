namespace Aula11Polimorfismo
{
    public class Dadosplayer
    {
        //sobre carga 
        public string Calcular(){
            return "Dados de jogador:";
        }
        public string Calcular(string nick){
            return $"Nick do jogador : {nick}";
        }
        public string Calcular(string nome, string sobrenome){
            return $"Nome do jodagor:{nome} {sobrenome}";
        }
        public string Calcular(string nivel, int fase){
            return $"Nivel do jogador: {nivel}" + (fase);
        }
        public string Calcular(int vida){
            return $"Vida do jogador:"+vida;
        }
        public string Calcular(int vida, int escudo){
            return $"Vida com escudo:"+(vida+escudo);
        }
    }
}