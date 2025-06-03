namespace EspacioCalculadora
{
    public class Calculadora{

        private double dato;
        
        //es el getter del atributo dato, getDato
        public double Resultado
        {
            get => dato;
        }

        //Constructor por defecto
        // public Calculadora(){
        // }

        //Constructor sin parametros
        // public Calculadora(){
        //     dato = 0;
        // }
        
        //Contructor por parametro
        public Calculadora(double valorInicial)
        {
            dato = valorInicial;
        }

        public void Sumar(double termino){
            dato+=termino;
        }
        public void Restar(double termino){
            dato-=termino;
        }
        public void Multiplicar(double termino){
            dato*=termino;
        }
        public void Dividir(double termino){
            if (termino !=0) {
                dato/=termino;
            }
        }
        public void Limpiar(){
            dato=0;
        }
    }
}