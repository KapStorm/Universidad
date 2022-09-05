package unidad1.hilos;

public class AppPrintTask {
    public static void main(String[] args) {
        Thread subproceso1 = new Thread(new PrintTask("Task 1"));

        PrintTask task2 = new PrintTask("Task 2");
        Thread subproceso2 = new Thread(task2);

        PrintTask task3 = new PrintTask("Task 3");
        Thread subproceso3 = new Thread(task3);

        System.out.println("Starting executor");

        subproceso1.start();
        subproceso2.start();
        subproceso3.start();

        System.out.println("Task started, main ends");
    }
}
