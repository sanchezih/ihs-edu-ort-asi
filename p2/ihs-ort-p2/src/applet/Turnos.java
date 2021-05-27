package applet;

import java.awt.*;
import java.applet.Applet;

public class Turnos extends Applet {
	
	// Objetos de Component
	Label etiq1 = new Label("Datos del Paciente:");
	TextField tf1 = new TextField(25);
	List listaDias = new List(3, false);
	List listaHorario = new List(3, false);
	Button b1 = new Button("Asignar Turno");

	public void init() {
		// A partir de aca ADD

		add(etiq1);

		add(tf1);

		listaDias.addItem("Domingo");
		listaDias.addItem("Lunes");
		listaDias.addItem("Martes");
		listaDias.addItem("Miercoles");
		listaDias.addItem("Jueves");
		listaDias.addItem("Viernes");
		listaDias.addItem("Sabado");
		add(listaDias);

		listaHorario.addItem("09:00 - 10:00");
		listaHorario.addItem("10:00 - 11:00");
		listaHorario.addItem("11:00 - 12:00");
		listaHorario.addItem("12:00 - 13:00");
		listaHorario.addItem("13:00 - 14:00");
		listaHorario.addItem("14:00 - 15:00");
		listaHorario.addItem("15:00 - 16:00");
		add(listaHorario);

		add(b1);
	}

	public boolean action(Event evento, Object objeto) {
		if (evento.target instanceof Button) {
			if ("Asignar Turno".equals(objeto)) {
				String puso = tf1.getText();
				String seleccionDia = listaDias.getSelectedItem();
				String seleccionHora = listaHorario.getSelectedItem();

				System.out.println("Paciente: " + puso);
				System.out.println("Turno seleccionado: " + seleccionDia + " a las: " + seleccionHora);
			}
		}
		return true;
	}
}