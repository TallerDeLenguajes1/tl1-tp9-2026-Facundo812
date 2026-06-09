using System;
using System.IO;

Console.WriteLine("Hello, World!");

//Console.Write("Ingrese el path del directorio que desea analizar: ");
//string path = Console.ReadLine();
string path = @"C:\Users\Alumno\Desktop\tp9\tl1-tp9-2026-Facundo812";

//controlar que exista el path
/*while(!Directory.Exists(path)){
    Console.Write("El directorio no existe, ingrese otro path: ");
    path = Console.ReadLine();
}*/

String[] directorios = Directory.GetDirectories(path);
String[] archivos = Directory.GetFiles(path);

foreach(string s in directorios){
    Console.WriteLine("Carpeta: "+ Path.GetFileName(s));
}

FileInfo info = new FileInfo();
foreach(string s in archivos){
    Console.WriteLine("Archivo: "+ Path.GetFileName(s));
}






