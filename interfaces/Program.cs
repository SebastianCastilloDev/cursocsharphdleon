class Bebida {
    public string Nombre { get; set; }
}

class Cerveza : Bebida {
    public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad) {

    }

}