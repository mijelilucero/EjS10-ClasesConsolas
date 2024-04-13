using EjS10.ClaseHija;

//instancia de nintendo
Nintendo nintendo= new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostrarDetalles());

//instancia de ps1
PlayStation ps=new PlayStation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloControlador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

//instancia de Xbox
Xbox xbox = new Xbox();
xbox.anioLanzamiento = 2015;
xbox.Marca = "Xbox";
xbox.kinet = true;
Console.WriteLine(xbox.MostrarDetalleXbox());

//instancia de SegaDreamCast
SegaDreamCast sega = new SegaDreamCast();
sega.Marca = "SegaDreamCast";
sega.anioLanzamiento = 1990;
sega.PantallaEnControl = true;
Console.WriteLine($"{sega.MostrarDetalleSegaDreamCast()}");