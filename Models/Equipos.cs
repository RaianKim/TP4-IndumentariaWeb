public static class Equipos
{
    
    static public List<string> ListaEquipos {get;private set;} = new List<string>(){"River ","Boca ","Racing ","Argentino Juniors ","Banfield ","Barrcas Central ","Huracan ","Independiente ","San Lorenzo ","Tigre "}; 
    static public List<string> ListaRemeras{get;private set;} = new List<string>(){"CamisetaBlanca.png", "CamisetaAzul.png","CamisetaRoja.png","CamisetaVerde.png"};
    static public List<string>ListaPantalones{get;private set;} = new List<string>(){"PantalonNegro.png", "PantalonAzul.png","PantalonBlanco.png","PantalonRojo.png"};
    static public List<string> ListaMedias{get;private set;} = new List<string>(){"MediasBlanco.png","MediasAzul.png","MediasRojas.png"};
    static public Dictionary<string,Indumentaria> EquiposIndumentaria {get;private set;} = new Dictionary<string, Indumentaria>();


static public bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria indumentaria)
{
    bool a = false;
    EquiposIndumentaria.Add(EquipoSeleccionado,indumentaria);
    return a;
}
}
