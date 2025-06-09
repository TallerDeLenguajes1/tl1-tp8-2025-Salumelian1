namespace Tareas
{
    public class tareas
    {
        public  int TareaID { get; set; }
        public string? descripcion { get; set; }
        public int Duracion { get; set; }

        public tareas(int id, string des, int dur)
        {
            TareaID = id;
            descripcion = des;
            Duracion = dur;
        }
    }
}