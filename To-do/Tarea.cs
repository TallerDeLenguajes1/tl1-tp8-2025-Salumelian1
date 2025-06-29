namespace tareas
{
    public class Tareas
    {
        public  int TareaID { get; set; }
        public string? descripcion { get; set; }
        public int Duracion { get; set; }

        public Tareas(int id, string des, int dur)
        {
            TareaID = id;
            descripcion = des;
            Duracion = dur;
        }
    }
}