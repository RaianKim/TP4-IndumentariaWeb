public class Indumentaria
{
    public string Medias{get; private set;}
    public string Pantalon{get; private set;}
    public string Camiseta{get; private set;}

    public Indumentaria()
    {

    }

    public Indumentaria(string Remera, string pantalon, string Media)
    {
        Camiseta=Remera;
        Pantalon=pantalon;
        Medias=Media;
    }
    

}