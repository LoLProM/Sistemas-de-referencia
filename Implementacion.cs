namespace Jose;

public class Implementacion
{
    public static Punto EsfericasACartesianas(CooEsfericas puntoEsferico)
    {
        double x = puntoEsferico.Modulo * Math.Sin(puntoEsferico.Omega) * Math.Cos(puntoEsferico.Cita);
        double y = puntoEsferico.Modulo * Math.Sin(puntoEsferico.Omega) * Math.Sin(puntoEsferico.Cita);
        double z = puntoEsferico.Modulo * Math.Cos(puntoEsferico.Omega);

        return new CooCartesiano(x,y,z);
    }

    public static Punto CilindricasACartesianas(CooCilindrico puntoCilindrico)
    {
        double x = puntoCilindrico.Modulo * Math.Cos(puntoCilindrico.Omega);
        double y = puntoCilindrico.Modulo * Math.Sin(puntoCilindrico.Omega);
        double z = puntoCilindrico.Z;

        return new CooCartesiana(x,y,z);
    }

    public static Punto CartesianasAEsfericas(CooCartesiana puntoCartesiano)
    {
        double modulo = Math.Sqrt(Math.Pow(puntoCartesiano.X,2) + Math.Pow(puntoCartesiano.Y,2) + Math.Pow(puntoCartesiano.Z,2));
        
        double omega = puntoCartesiano.Z == 0 ? Math.PI / 2 : Math.Atan((Math.Sqrt(Math.Pow(puntoCartesiano.X,2) + Math.Pow(puntoCartesiano.Y,2))) / puntoCartesiano.Z);

        double cita = puntoCartesiano.X == 0 ? Math.PI / 2 : Math.Atan(puntoCartesiano.Y / puntoCartesiano.X);
        
        return new CooEsfericas(modulo,omega,cita);
    }

    public static Punto CartesianasACilindricas(CooCartesianas puntoCartesiano)
    {
        double modulo = Math.Sqrt(Math.Pow(puntoCartesiano.X,2) + Math.Pow(puntoCartesiano.Y,2) + Math.Pow(puntoCartesiano.Z,2));
        
        double omega = puntoCartesiano.X == 0 ? Math.PI / 2 : Math.Atan(puntoCartesiano.Y / puntoCartesiano.X);

        double z = puntoCartesiano.Z;

        return new CooCilindricas(modulo,omega,z);
    }
}