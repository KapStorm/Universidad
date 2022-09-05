package unidad1.hilos;

import java.util.Random;

public class PrintTask implements Runnable {
    private final int sleepTime;
    private final String taskName;
    private final Random generator;

    public PrintTask(String taskName) {
        this.taskName = taskName;
        generator = new Random();
        sleepTime = generator.nextInt(5000);
    }

    @Override
    public void run() {
        try {
            System.out.printf("%s is going to sleep from %d\n",
                    taskName, sleepTime);
            Thread.sleep(sleepTime);
            System.out.printf("%s continua la ejecucion\n",
                    taskName);
        } catch (InterruptedException e) {
            System.out.printf("%s therminated prematurely due to interna exception\n",
                    taskName);
        }
    }
}
