public static class Equipos
{
    
    static public List<string> ListaEquipos {get;private set;} = new List<string>(){"River ","Boca ","Racing ","Argentino Juniors ","Banfield ","Barrcas Central ","Huracan ","Independiente ","San Lorenzo ","Tigre "}; 
    static public List<string> ListaRemeras{get;private set;} = new List<string>(){"Camiseta Blanca", "Camiseta Azul","Camiseta Roja","Camiseta Verde"};
    static public List<string>ListaPantalones{get;private set;} = new List<string>(){"Pantalon Negro", "Pantalon Azul","Pantalon Blanca","Pantalon Rojo"};
    static public List<string> ListaMedias{get;private set;} = new List<string>(){"Medias Blanca","Medias Azul","Medias Roja"};
    static public Dictionary<string,Indumentaria> EquiposIndumentaria {get;private set;}


static public bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria indumentaria)
{
    bool a = false;
    EquiposIndumentaria.Add(EquipoSeleccionado,indumentaria);
    return a;
}
}
