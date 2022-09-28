package unidad3.primos;

import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import javax.swing.JButton;
import javax.swing.JProgressBar;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.ScrollPaneConstants;
import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.util.concurrent.ExecutionException;
import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeEvent;

/**
 * @author ADM
 */
public class FindPrimes extends JFrame {
    private final JTextField highestPrimeJTextField = new JTextField();
    private final JButton getPrimesJButton = new JButton("Get Primes");
    private final JTextArea displayPrimesJTextArea = new JTextArea();
    private final JButton cancelJButton = new JButton("Cancel");
    private final JProgressBar progressJProgressBar = new JProgressBar();
    private final JLabel statusJLabel = new JLabel();
    private CalculadoraPrimosThreads calculator;

    public FindPrimes() {
        super("Finding Primes with SwingWorker");
        setLayout(new BorderLayout());

        // initialize panel to get a number from the user
        JPanel northJPanel = new JPanel();
        northJPanel.add(new JLabel("Find primes less than: "));
        highestPrimeJTextField.setColumns(5);
        northJPanel.add(highestPrimeJTextField);
        getPrimesJButton.addActionListener(
                new ActionListener() {
                    public void actionPerformed(ActionEvent e) {
                        progressJProgressBar.setValue(0); // reset JProgressBar
                        displayPrimesJTextArea.setText(""); // clear JTextArea
                        statusJLabel.setText(""); // clear JLabel

                        int number; // search for primes up through this value
                        try {

                            number = Integer.parseInt(
                                    highestPrimeJTextField.getText());
                        } // end try
                        catch (NumberFormatException ex) {
                            statusJLabel.setText("Enter an integer.");
                            return;
                        } // end catch
                        // construct a new PrimeCalculator object
                        calculator = new CalculadoraPrimosThreads(number,
                                displayPrimesJTextArea, statusJLabel, getPrimesJButton,
                                cancelJButton);
                        calculator.addPropertyChangeListener(
                                new PropertyChangeListener() {
                                    public void propertyChange(PropertyChangeEvent e) {
// if the changed property is progress,
// update the progress bar
                                        if (e.getPropertyName().equals("progress")) {
                                            int newValue = (Integer) e.getNewValue();
                                            progressJProgressBar.setValue(newValue);
                                        } // end if
                                    } // end method propertyChange
                                } // end anonymous inner class
                        ); // end call to addPropertyChangeListener
                        getPrimesJButton.setEnabled(false);
                        cancelJButton.setEnabled(true);
                        calculator.execute(); // execute the PrimeCalculator object

                    }
                }
        );
        northJPanel.add(getPrimesJButton);
        displayPrimesJTextArea.setEditable(false);
        add(new JScrollPane(displayPrimesJTextArea,
                ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS,
                ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER));

        JPanel southJPanel = new JPanel(new GridLayout(1, 3, 10, 10));
        cancelJButton.setEnabled(false);
        cancelJButton.addActionListener(
                new ActionListener() {
                    public void actionPerformed(ActionEvent e) {
                        calculator.cancel(true); // cancel the calculation
                    } // end method ActionPerformed
                } // end anonymous inner class
        ); // end call to addActionListener
        southJPanel.add(cancelJButton);
        progressJProgressBar.setStringPainted(true);
        southJPanel.add(progressJProgressBar);
        southJPanel.add(statusJLabel);

        add(northJPanel, BorderLayout.NORTH);
        add(southJPanel, BorderLayout.SOUTH);
        setSize(350, 300);
        setVisible(true);
    }

    public static void main(String[] args) {
        FindPrimes application = new FindPrimes();
        application.setDefaultCloseOperation(EXIT_ON_CLOSE);
    } // end main
} // end class FindPrimes
