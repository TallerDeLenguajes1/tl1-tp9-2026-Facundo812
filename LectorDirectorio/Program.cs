using System;
using System.IO;

Console.Write("Ingrese el path del directorio que desea analizar: ");
string path = Console.ReadLine();

//path para prueba
//string path = @"C:\tp9\tl1-tp9-2026-Facundo812";

//controlar que exista el path
while(!Directory.Exists(path)){
    Console.Write("El directorio no existe, ingrese otro path: ");
    path = Console.ReadLine();
}

string reporte = path + @"\reporte_archivos.csv";

String[] directorios = Directory.GetDirectories(path);
String[] archivos = Directory.GetFiles(path);

foreach(string s in directorios){
    Console.WriteLine("Carpeta: "+ Path.GetFileName(s));
}

string[] matriz = new string[archivos.Length];
int i = 0;

foreach(string s in archivos){
    FileInfo F = new FileInfo(s);
    double tamKB = (float)F.Length/1024;

    Console.WriteLine("Archivo: "+Path.GetFileName(s)+", tamanio: "+tamKB.ToString("F2")+"KB");

    matriz[i] = Path.GetFileName(s)+"   "+tamKB.ToString("F2")+"KB   "+F.LastWriteTime;
    i++;
}

File.WriteAllLines(reporte,matriz);






