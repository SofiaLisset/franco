class Vehiculo{
        private  string Motor;
        private  string Rueda;
        private  float Velocidad;
        private Coordenada Posicion;

        Vehiculo (){
            Motor = "Generico";
            Rueda = "Generico";
            Velocidad = 0.0f;
            Posicion = new Coordenada (0,0);
        }
	//Falta Constructor sobrecargado :
    
    Vehiculo (string motor, float velocida, Coordenada posicion)
    {


    }

}

