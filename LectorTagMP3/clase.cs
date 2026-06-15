namespace EspacioMp3;

public class Mp3
{
    private string titulo;
    private string artista;
    private string album;
    private string anio;

    public Mp3(string a, string b, string c, string d)
    {
        this.titulo = a;
        this.artista = b;
        this.album = c;
        this.anio = d;
    }
    public void mostrarDatos()
    {
        Console.WriteLine("Titulo: "+titulo);
        Console.WriteLine("Artista: "+artista);
        Console.WriteLine("Album: "+album);
        Console.WriteLine("Anio de la cancion: "+anio);
    }
}