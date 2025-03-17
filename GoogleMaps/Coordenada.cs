using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Coordenada{                               /*Clase*/

        private int X;                          /*Atributos*/
        private int Y;

        public Coordenada (){                   /*Constructor por defecto*/
            X = 0;
            Y = 0;
        }

        public Coordenada (int X, int Y){      /*Constructor sobrecarga*/
            this.X = X;
            this.Y = Y;
        }

        public int GetX (){     /*Metodos Getters y Setters*/
            return X;
        }

        public int GetY (){     
            return Y;
        }
        public void SetX(int X){             
           this.X = X;
        }
        
        public void SetY(int Y){
           this.Y = Y;
        }

}