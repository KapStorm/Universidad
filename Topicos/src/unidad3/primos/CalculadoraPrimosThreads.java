package unidad3.primos;

import javax.swing.JTextArea;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.SwingWorker;
import java.util.Arrays;
import java.util.Random;
import java.util.List;
import java.util.concurrent.CancellationException;
import java.util.concurrent.ExecutionException;

/**
 * @author ADM
 */
public class CalculadoraPrimosThreads extends SwingWorker<Integer, Integer> {


    private final Random generator = new Random();
    private final JTextArea intermediateJTextArea; // displays found primes
    private final JButton getPrimesJButton;
    private final JButton cancelJButton;
    private final JLabel statusJLabel; // displays status of calculation
    private final boolean[] primes;

    CalculadoraPrimosThreads(int max, JTextArea intermediate, JLabel status,
                             JButton getPrimes, JButton cancel) {
        intermediateJTextArea = intermediate;
        statusJLabel = status;
        getPrimesJButton = getPrimes;
        cancelJButton = cancel;
        primes = new boolean[max];
        Arrays.fill(primes, true);
    }

    public Integer doInBackground() {
        int count = 0; // the number of primes found

        // starting at the third value, cycle through the array and put

        for (int i = 2; i < primes.length; i++) {
            if (isCancelled()) // if calculation has been canceled
                return count;
            else {
                setProgress(100 * (i + 1) / primes.length);
                try {
                    Thread.sleep(generator.nextInt(5));
                } // end try
                catch (InterruptedException ex) {
                    statusJLabel.setText("Worker thread interrupted");
                    return count;
                } // end catch

                if (primes[i]) // i is prime
                {
                    publish(i); // make i available for display in prime list
                    ++count;

                    for (int j = i + i; j < primes.length; j += i)
                        primes[j] = false; // i is not prime
                } // end if
            } // end else
        } // end for

        return count;
    }

    protected void process(List<Integer> publishedVals) {
        for (int i = 0; i < publishedVals.size(); i++)
            intermediateJTextArea.append(publishedVals.get(i) + "\n");
    } // end method process

    protected void done() {
        getPrimesJButton.setEnabled(true); // enable Get Primes button
        cancelJButton.setEnabled(false); // disable Cancel button

        int numPrimes;

        try {
            numPrimes = get(); // retrieve doInBackground return value

        } catch (InterruptedException ex) {
            statusJLabel.setText("Interrupted while waiting for results.");
            return;
        } // end catch

        catch (ExecutionException ex) {
            statusJLabel.setText("Error performing computation.");
            return;
        } catch (CancellationException ex) {
            statusJLabel.setText("Canceled");
            return;
        }
        statusJLabel.setText("Found " + numPrimes + " primes.");
    }


}
