import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class VentanaPrincipal extends JFrame {
    private JPanel panelPreguntas;
    private JButton btnSiguiente;
    private JLabel lblPregunta;
    private JRadioButton[] radioButtons;
    private ButtonGroup grupoBotones;
    private DAOPreguntas preguntas;

    public VentanaPrincipal() {
        setTitle("Test de Preguntas");
        setSize(500, 300);

        preguntas = new DAOPreguntas();

        panelPreguntas = new JPanel(new BorderLayout());
        lblPregunta = new JLabel();
        panelPreguntas.add(lblPregunta, BorderLayout.NORTH);

        radioButtons = new JRadioButton[4];
        grupoBotones = new ButtonGroup();
        JPanel panelOpciones = new JPanel(new GridLayout(4, 1));
        for (int i = 0; i < 4; i++) {
            radioButtons[i] = new JRadioButton();
            grupoBotones.add(radioButtons[i]);
            panelOpciones.add(radioButtons[i]);
        }
        panelPreguntas.add(panelOpciones, BorderLayout.CENTER);

        btnSiguiente = new JButton("Siguiente");
        btnSiguiente.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                siguientePregunta();
            }
        });

        getContentPane().add(panelPreguntas, BorderLayout.CENTER);
        getContentPane().add(btnSiguiente, BorderLayout.SOUTH);

        mostrarPregunta();
    }

    private void mostrarPregunta() {
        Pregunta preguntaActual = preguntas.obtenerPreguntaActual();

        if (preguntaActual != null) {
            lblPregunta.setText(preguntaActual.getEnunciado());

            String[] opciones = preguntaActual.getOpciones();
            for (int i = 0; i < 4; i++) {
                radioButtons[i].setText(opciones[i]);
            }
        } else {
            JOptionPane.showMessageDialog(this, "Test completado con éxito");
        }
    }

    private void siguientePregunta() {
        Pregunta preguntaActual = preguntas.obtenerPreguntaActual();

        if (preguntaActual != null) {
            int respuestaSeleccionada = -1;
            for (int i = 0; i < 4; i++) {
                if (radioButtons[i].isSelected()) {
                    respuestaSeleccionada = i;
                    break;
                }
            }

            if (respuestaSeleccionada == preguntaActual.getRespuestaCorrecta()) {
                JOptionPane.showMessageDialog(this, "¡Respuesta correcta!");
            } else {
                JOptionPane.showMessageDialog(this, "Respuesta incorrecta. La respuesta correcta era: " + preguntaActual.getRespuestaCorrecta());
            }

            preguntas.avanzarPregunta();

            mostrarPregunta();
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            new VentanaPrincipal().setVisible(true);
        });
    }
}

