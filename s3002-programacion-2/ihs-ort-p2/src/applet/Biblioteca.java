package applet;

import java.awt.*;
import java.applet.Applet;

public class Biblioteca extends Applet {
	TextField tex1 = new TextField(40);
	TextField tex2 = new TextField(40);
	TextField tex3 = new TextField(40);
	CheckboxGroup radio = new CheckboxGroup();
	Button boton1 = new Button("Grabar");

	List listaNivel = new List(3, false);
	TextField tex4 = new TextField(40);

	public void paint(Graphics g) {
		g.drawString("Apellido: ", 10, 10);
		g.drawString("Nombre: ", 10, 40);
		g.drawString("Dirección: ", 10, 70);
		g.drawString("Sexo: ", 10, 100);
		g.drawString("Nivel de estudios: ", 10, 130);
		g.drawString("Fecha de adhesión: ", 10, 170);
	}

	public void init() {
		this.add(tex1);
		this.add(tex2);
		this.add(tex3);
		add(new Checkbox("Masculino", radio, false));
		add(new Checkbox("Femenino", radio, false));

		listaNivel.addItem("Primario");
		listaNivel.addItem("Secundario");
		listaNivel.addItem("Terciario");

		this.add(listaNivel);
		this.add(tex4);
		this.add(boton1);
	}

	public boolean action(Event evt, Object obj) {
		if (evt.target instanceof Button) {
			if ("Grabar".equals(obj)) {
				String apellido = tex1.getText();
				String nombre = tex2.getText();
				String direccion = tex3.getText();
				String sexo = radio.getSelectedCheckbox().getLabel();
				String seleccionNivel = listaNivel.getSelectedItem();
				String fecha = tex4.getText();
				System.out.println("Socio: " + apellido + " " + nombre);
				System.out.println("Dirección: " + direccion);
				System.out.println("Sexo: " + sexo);
				System.out.println("Nivel de estudio: " + seleccionNivel);
				System.out.println("Fecha de adhesión: " + fecha);
			}
		}
		return true;
	}
}
