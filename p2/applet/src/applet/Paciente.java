package applet;

import java.awt.*;
import java.applet.Applet;

/** @modelguid {B9E027D6-FB80-43E0-BDB6-D47974CAEAB9} */
public class Paciente extends Applet {

	/** @modelguid {DEA20241-1300-4F80-BFFA-8E3CB989E8C3} */
	Button boton1 = new Button("Asignar Turno");

	/** @modelguid {6A08CF78-FA34-4CEC-AB10-07C4DC00EE20} */
	List listaDia = new List(7, false);

	/** @modelguid {4BA70521-640E-42AC-AA75-4556DC9640F3} */
	List listaHora = new List(7, false);

	/** @modelguid {FC2D9105-6903-4DE6-98E6-85132A200538} */
	TextField texto = new TextField(40);

	/** @modelguid {615F6C1A-5347-4DA8-80A3-D375A157A7B4} */
	public void paint(Graphics g) {
		g.drawString("Datos del paciente:", 10, 10);
	}

	/** @modelguid {EE436D79-D3F5-4F3A-80ED-867A338571A1} */
	public void init() {

		this.add(texto);

		listaDia.addItem("Lunes");
		listaDia.addItem("Martes");
		listaDia.addItem("Miercoles");
		listaDia.addItem("Jueves");
		listaDia.addItem("Viernes");
		listaDia.addItem("Sabado");
		listaDia.addItem("Domingo");
		listaHora.addItem("09:00-10:00");
		listaHora.addItem("10:00-11:00");
		listaHora.addItem("11:00-12:00");
		listaHora.addItem("12:00-13:00");
		listaHora.addItem("13:00-14:00");
		listaHora.addItem("14:00-15:00");
		listaHora.addItem("15:00-16:00");

		this.add(listaDia);
		this.add(listaHora);
		this.add(boton1);
	}

	/** @modelguid {7594B0EE-E24E-4330-A7ED-5911FDA6EF60} */
	public boolean action(Event evt, Object obj) {

		if (evt.target instanceof Button) {
			if ("Asignar Turno".equals(obj)) {
				String puso = texto.getText();
				String seleccionDia = listaDia.getSelectedItem();
				String seleccionHora = listaHora.getSelectedItem();
				System.out.println("Paciente: " + puso);
				System.out.println("Turno seleccionado: " + seleccionDia + " a las: " + seleccionHora);

			}

		}
		return true;
	}

}
