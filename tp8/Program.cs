using tareas;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Random random = new Random();
        int NumeroDeTareas = random.Next(1, 11);
        string[] descripciones ={ "A","B","C","D","e","f","g","h","i","j","i","k"};
        var pendientes = new List<Tarea>();
        var realizadas = new List<Tarea>();
        for(int i=0;i<NumeroDeTareas;i++){
            pendientes.Add(new Tarea(i+1,descripciones[i],(new Random()).Next(1,11)));
        }
    }

    void MostrarTarea(Tarea tarea){
        Console.WriteLine("El id de la tarea es"+ tarea.Id);
        Console.WriteLine("La descripcion es"+ tarea.descripcion);
        Console.WriteLine("La duracion de la tarea es"+ tarea.duracion);

    }
    void MoverTarea(List<Tarea> Pendientes,List<Tarea> realizadas, int ID){
        foreach(Tarea tarea in Pendientes){
            if(tarea.Id == ID){
                realizadas.Add(tarea);
                Pendientes.Remove(tarea);
            }
        }

    }
    void InterfazMover(List<Tarea> Pendientes,List<Tarea> realizadas){
        string? opcion;
        Console.WriteLine("¿Desea Finalizar alguna tarea?");
        opcion = Console.ReadLine();
        if (opcion == "si"){
            Console.WriteLine("Ingrese la id de la tarea a finalizar");
            int IDInt;
            string?IDstring = Console.ReadLine();
            while(!int.TryParse(IDstring,out IDInt)){
                Console.WriteLine("Ingrese una ID valida");
                IDstring = Console.ReadLine();
            }
            MoverTarea(Pendientes,realizadas,IDInt);
            Console.WriteLine("Tarea Realizada con exito");
        }
}

void BuscarPorDescripcion(List<Tarea> Pendientes,List<Tarea> realizadas){
    String? Desc = Console.ReadLine();
    foreach(Tarea tarea in Pendientes){
        if(tarea.descripcion == Desc){
            MostrarTarea(tarea);
        }
    }

}
}

