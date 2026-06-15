using System;
using System.IO;
using System.Text;
using EspacioMp3;

//direccion del archivo
string path = Directory.GetCurrentDirectory() +@"\Spoons-Telecasted.mp3.mpeg";

FileStream archivo = new FileStream(path, FileMode.Open); //abrir archivo
archivo.Seek(-128,SeekOrigin.End); //posisionar al final



byte[] buffer = new byte[128];
archivo.ReadExactly(buffer,0,128); //leer los bytes y guardarlos en el buffer


//leer buffer
string titulo = Encoding.UTF8.GetString(buffer, 3, 30);
string artista = Encoding.UTF8.GetString(buffer, 33, 30);
string album = Encoding.UTF8.GetString(buffer, 63, 30);
string anio = Encoding.UTF8.GetString(buffer, 93, 4);

//guardar en clase
Mp3 Tag = new Mp3(titulo, artista, album, anio);
Tag.mostrarDatos();