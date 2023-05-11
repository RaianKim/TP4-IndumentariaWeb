public static class Equipos

{
    
    static public List<string> ListaEquipos {get;private set;} = new List<string>(){"River","Boca","Racing","Argentino Juniors","Banfield","Barrcas Central","Huracan","Independiente","San Lorenzo","Tigre"}; 
    static public List<string> ListaRemeras{get;private set;} = new List<string>(){"Camiseta Roja","Camiseta Azul","Camiseta Azul","Camiseta Blanca","Camiseta Verde"};
    static public List<string>ListaPantalones{get;private set;} = new List<string>(){"Pantalon Blanca", "Pantalon Azul", "Pantalon Rojo"};
    static public List<string> ListaMedias{get;private set;} = new List<string>(){"Medias Blanca","Medias Azul","Medias Roja"};
    public static Dictionary<string,Indumentaria> EquiposIndumentaria {get;private set;}


static public bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
{
    EquiposIndumentaria.Add(EquipoSeleccionado,item);
    bool a = false;
    return a;
}
}
