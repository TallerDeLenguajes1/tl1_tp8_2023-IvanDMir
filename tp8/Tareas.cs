namespace tareas {

    public class Tarea {
        private int ID;
        private string Descripcion;
        private int Duracion;
    

    public int Id {get => ID; }
    public string descripcion {get =>Descripcion;}
    public int duracion {get =>Duracion;}
    public Tarea(
        int ID,
        string Descripcion,
        int Duracion)
    {
        this.ID = ID;
        this.Descripcion=Descripcion;
        this.Duracion=Duracion;
    }

}
}