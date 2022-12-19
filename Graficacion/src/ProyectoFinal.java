import java.util.Random;

public class ProyectoFinal {

    public static Random RNG = new Random();

    public static void main(String[] args) {
        final int NUMTURNOS = 60;
        //Se pueden almacenar los resultados finales en una matriz... ¿¿¿tal vez???

        float[][] costesAcumulado = {{3, 0, 0, 0, 0, 0}, {4, 0, 0, 0, 0, 0}, {5, 0, 0, 0, 0, 0}, {6, 0, 0, 0, 0, 0}};
        //Se realizará la simulación por turnos, turno 1: equipo 3, 4, 5, 6....
        for (int turnoActual = 1; turnoActual <= NUMTURNOS; turnoActual++) {
            int punteroMatriz = 0;
            //Hace la simulación de un turno para cada equipo
            System.out.println();
            System.out.println("TURNO ACTUAL: " + turnoActual);
            for (int equipoActual = 3; equipoActual <= 6; equipoActual++) {
                if (punteroMatriz > 3) punteroMatriz = 0;
                System.out.println();
                System.out.println("Tamaño del equipo: " + equipoActual);

                System.out.printf("Núm. Aleatorio | T/Llegadas | Tiempo de Llegada | Inic. Serv. | Num. Aleatorio | T. del Serv | Term. del Serv. | Ocio personal | T. esp camión | cola");
                System.out.println();
                // El turno es de *8 HORAS*, comienza a las 11,
                // pasadas 4 horas, a partir de las 3, hay un descanso de 30 minutos.
                int horasTrabajadas = 0, minutosTrabajados = 0;
                int tiempoExtra = 0;
                int ocioPersonal = 0, esperaCamion = 0, esperaCamionAcumulada = 0;
                int horaReloj = 11, minutosReloj = 0;
                boolean lonche = false, ajusteLonche = false;
                float randomColaInicial = RNG.nextFloat();
                int longitudCola = CamionesIniciales(randomColaInicial);
                float randomTiempoServicio = RNG.nextFloat();
                int tiempoLlegada = 0, tiempoServicio = 0;

                String horaInicioServicio = "";
                tiempoServicio = TiempoServicio(equipoActual, randomTiempoServicio);
                String horaFinServicio = HoraProyectada(horaReloj, minutosReloj, tiempoServicio);
                System.out.printf(" \t\t\t  |\t\t\t     | 11:00 \t | 11:00 \t | " + randomTiempoServicio + "\t\t | " + tiempoServicio + "\t\t \t| " + horaFinServicio + "\t\t | " + ocioPersonal + "\t\t | " + esperaCamion + "\t\t | " + longitudCola);
                System.out.println();
                //Jornada normal de 11 a 7:30
                while (minutosTrabajados < 480 || (horaReloj >= 7 && horaReloj <= 9) || longitudCola > 0) {
                    if ((horaReloj >= 7 && horaReloj <= 9 && minutosReloj + tiempoServicio >= 30) || minutosTrabajados / 60 >= 8) {
                        break;
                    } else {
                        //Obtiene el tiempo entre llegadas
                        float randomTiempoLlegada = RNG.nextFloat();
                        tiempoLlegada = TiempoEntreLlegadas(randomTiempoLlegada);
                        String horaLlegada = HoraProyectada(horaReloj, minutosReloj, tiempoLlegada);
                        minutosTrabajados += tiempoLlegada;

                        if (minutosTrabajados >= 480 || (horaReloj >= 7 && minutosReloj >= 30 && lonche)) {
                            System.out.println("Terminando simulación. Siguiente cargamento arriva a las " + horaLlegada);
                            break;
                        }

                        if (minutosReloj >= 60) {
                            horaReloj++;
                            if (horaReloj > 12) horaReloj = 1;
                            minutosReloj -= 60;
                        }
                        //Saca el tiempo de inicio del servicio:
                        if (((horaReloj >= 3 && horaReloj <= 5)) && !lonche) {
                            lonche = true;
                            minutosReloj += 30;
                            esperaCamion = 30;
                            esperaCamionAcumulada += esperaCamion;

                            if (minutosReloj >= 60) {
                                horaReloj++;
                                if (horaReloj > 12) horaReloj = 1;
                                minutosReloj -= 60;
                            }
                        }

                        if (tiempoServicio > tiempoLlegada) {
                            ocioPersonal = 0;
                            longitudCola++;
                            esperaCamion = tiempoServicio - tiempoLlegada;
                            esperaCamionAcumulada += esperaCamion;
                            horaInicioServicio = HoraProyectada(horaReloj, minutosReloj, tiempoServicio + esperaCamion);

                        } else if (tiempoLlegada > tiempoServicio) {
                            if (longitudCola > 0) longitudCola--;
                            if (longitudCola == 0) esperaCamion = 0;
                            else esperaCamion += tiempoServicio;
                            if (esperaCamion == 0) ocioPersonal = tiempoLlegada - tiempoServicio;
                            else {
                                esperaCamionAcumulada += esperaCamion;
                            }
                            horaInicioServicio = HoraProyectada(horaReloj, minutosReloj, tiempoLlegada);

                        } else {
                            if (longitudCola > 0)
                                horaInicioServicio = HoraProyectada(horaReloj, minutosReloj, tiempoLlegada);
                            ocioPersonal = 0;
                            esperaCamion = 0;
                        }
                        minutosReloj += tiempoLlegada;
                        horaFinServicio = HoraProyectada(horaReloj, minutosReloj, tiempoServicio);
                        System.out.printf(randomTiempoLlegada + "\t  | \t " + tiempoLlegada + " \t | \t " + horaLlegada + " \t | \t " + horaInicioServicio + " \t | \t " + randomTiempoServicio + "\t\t | \t\t" + tiempoServicio + "\t\t | \t\t" + horaFinServicio + "\t\t | \t\t" + ocioPersonal + "\t\t | \t\t" + esperaCamion + "\t\t | \t\t" + longitudCola);
                        System.out.println();
                        //System.out.printf(randomTiempoLlegada + " | "+ tiempoLlegada + " | "+ horaLlegada + " | " + horaInicioServicio  + " | " + randomTiempoServicio + " | " + tiempoServicio + " | " + horaFinServicio + " | " + ocioPersonal + " | " + esperaCamion + " | " + longitudCola );

                        if (lonche && !ajusteLonche) ajusteLonche = true;
                        else {
                            randomTiempoServicio = RNG.nextFloat();
                            tiempoServicio = TiempoServicio(equipoActual, randomTiempoServicio);
                        }

                    }

                }
                horasTrabajadas = (int) Math.floor(minutosTrabajados / 60);

                if (minutosTrabajados > 480) {
                    tiempoExtra = minutosTrabajados - 480;
                    horasTrabajadas = 8;
                } else tiempoExtra = 0;
                double salarioNormal = 25 * 8 * equipoActual;
                double salarioExtra = equipoActual * tiempoExtra / 60 * 37.5;
                double costoEspera = 8 * 100 + (100 * esperaCamionAcumulada / 60);
                double costoOperativo = 8 * 500 + (500 * tiempoExtra / 60);
                double costosTotales = salarioNormal + salarioExtra + costoEspera + costoOperativo;
                costesAcumulado[punteroMatriz][1] += salarioNormal;
                costesAcumulado[punteroMatriz][2] += salarioExtra;
                costesAcumulado[punteroMatriz][3] += costoEspera;
                costesAcumulado[punteroMatriz][4] += costoOperativo;
                costesAcumulado[punteroMatriz][5] += costosTotales;
                punteroMatriz++;
            }
        }
        System.out.println();
        int c = 3;
        System.out.println("\t COSTES PROMEDIO \t");
        System.out.printf("Equipo\t|Sal. Normal|Sal. Extra|Ocio Camión\t|Op. de Almacen\t|Costos Totales");
        System.out.println();
        for (int i = 0; i < 4; i++) {
            System.out.printf(c + "\t");
            for (int j = 1; j < 6; j++) {
                System.out.printf("\t|\t" + costesAcumulado[i][j] / 60);
            }
            System.out.println();
            c++;
        }
        System.out.println();
    }

    //A partir de una hora dada, y un intervalo de tiempo, calcula la hora en que termina
    public static String HoraProyectada(int hora, int minutos, int duracionAccion) {
        minutos += duracionAccion;
        while (minutos >= 60) {
            if (minutos >= 60) {
                minutos -= 60;
                hora++;
            }
        }
        if (hora > 12) hora = 1;

        if (minutos < 10) return hora + ":0" + minutos;
        return hora + ":" + minutos;
    }

    //Retorna el número de camiones al iniciar la jornada
    public static int CamionesIniciales(float randomGenerado) {
        if (randomGenerado < 0.5) return 0;
        if (randomGenerado >= 0.5 && randomGenerado < 0.75) return 1;
        if (randomGenerado >= 0.75 && randomGenerado < 0.9) return 2;
        return 3;
    }

    //Retorna el tiempo entre llegadas.
    public static int TiempoEntreLlegadas(float randomGenerado) {
        if (randomGenerado < 0.02) return 20;
        if (randomGenerado >= 0.02 && randomGenerado < 0.1) return 25;
        if (randomGenerado >= 0.1 && randomGenerado < 0.22) return 30;
        if (randomGenerado >= 0.22 && randomGenerado < 0.47) return 35;
        if (randomGenerado >= 0.47 && randomGenerado < 0.67) return 40;
        if (randomGenerado >= 0.67 && randomGenerado < 0.82) return 45;
        if (randomGenerado >= 0.82 && randomGenerado < 0.92) return 50;
        if (randomGenerado >= 0.92 && randomGenerado < 0.97) return 55;
        return 60;
    }

    //Retorna el tiempo de servicio
    public static int TiempoServicio(int teamSize, float randomGenerado) {
        int tiempoServ = 0;
        //Se le asigna un valor a tiempoServ a partir del tamaño del equipo y el random generado
        switch (teamSize) {
            case 3 -> {
                if (randomGenerado < 0.05) tiempoServ = 20;
                if (randomGenerado >= 0.05 && randomGenerado < 0.15) tiempoServ = 25;
                if (randomGenerado >= 0.15 && randomGenerado < 0.35) tiempoServ = 30;
                if (randomGenerado >= 0.35 && randomGenerado < 0.60) tiempoServ = 35;
                if (randomGenerado >= 0.60 && randomGenerado < 0.72) tiempoServ = 40;
                if (randomGenerado >= 0.72 && randomGenerado < 0.82) tiempoServ = 45;
                if (randomGenerado >= 0.82 && randomGenerado < 0.90) tiempoServ = 50;
                if (randomGenerado >= 0.90 && randomGenerado < 0.96) tiempoServ = 55;
                if (randomGenerado >= 0.96 && randomGenerado <= 1) tiempoServ = 60;
            }
            case 4 -> {
                if (randomGenerado < 0.05) tiempoServ = 15;
                if (randomGenerado >= 0.05 && randomGenerado < 0.20) tiempoServ = 20;
                if (randomGenerado >= 0.20 && randomGenerado < 0.40) tiempoServ = 25;
                if (randomGenerado >= 0.40 && randomGenerado < 0.60) tiempoServ = 30;
                if (randomGenerado >= 0.60 && randomGenerado < 0.75) tiempoServ = 35;
                if (randomGenerado >= 0.75 && randomGenerado < 0.87) tiempoServ = 40;
                if (randomGenerado >= 0.87 && randomGenerado < 0.95) tiempoServ = 45;
                if (randomGenerado >= 0.95 && randomGenerado < 0.99) tiempoServ = 50;
                if (randomGenerado >= 0.99 && randomGenerado <= 1) tiempoServ = 55;
            }
            case 5 -> {
                if (randomGenerado < 0.1) tiempoServ = 10;
                if (randomGenerado >= 0.1 && randomGenerado < 0.28) tiempoServ = 15;
                if (randomGenerado >= 0.28 && randomGenerado < 0.50) tiempoServ = 20;
                if (randomGenerado >= 0.50 && randomGenerado < 0.68) tiempoServ = 25;
                if (randomGenerado >= 0.68 && randomGenerado < 0.78) tiempoServ = 30;
                if (randomGenerado >= 0.78 && randomGenerado < 0.86) tiempoServ = 35;
                if (randomGenerado >= 0.86 && randomGenerado < 0.92) tiempoServ = 40;
                if (randomGenerado >= 0.92 && randomGenerado < 0.97) tiempoServ = 45;
                if (randomGenerado >= 0.97 && randomGenerado <= 1) tiempoServ = 50;
            }
            case 6 -> {
                if (randomGenerado < 0.12) tiempoServ = 5;
                if (randomGenerado >= 0.12 && randomGenerado < 0.27) tiempoServ = 10;
                if (randomGenerado >= 0.27 && randomGenerado < 0.53) tiempoServ = 15;
                if (randomGenerado >= 0.53 && randomGenerado < 0.68) tiempoServ = 20;
                if (randomGenerado >= 0.68 && randomGenerado < 0.80) tiempoServ = 25;
                if (randomGenerado >= 0.80 && randomGenerado < 0.88) tiempoServ = 30;
                if (randomGenerado >= 0.88 && randomGenerado < 0.94) tiempoServ = 35;
                if (randomGenerado >= 0.94 && randomGenerado < 0.98) tiempoServ = 40;
                if (randomGenerado >= 0.98 && randomGenerado <= 1) tiempoServ = 45;
            }
        }
        return tiempoServ;
    }
}