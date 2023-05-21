package applet;

import java.awt.*;
import java.applet.Applet;

public class Altas extends Applet {
	
	// Objetos de Component
	Label etiqueta1 = new Label("Datos del nuevo socio:");

	Label etiquetaApellido = new Label("Apellido:");
	TextField textoApellido = new TextField(25);

	Label etiquetaNombre = new Label("Nombre:");
	TextField textoNombre = new TextField(25);

	Label etiquetaDireccion = new Label("Direccion:");
	TextField textoDireccion = new TextField(25);

	Choice selectorEstudios = new Choice();

	CheckboxGroup sexo = new CheckboxGroup();

	Button botonAlta = new Button("Dar de alta al nuevo socio");

	public void init() {
		
		// A partir de aca ADD
		add(etiqueta1);

		add(etiquetaApellido);
		add(textoApellido);

		add(etiquetaNombre);
		add(textoNombre);

		add(etiquetaDireccion);
		add(textoDireccion);

		selectorEstudios.addItem("Primario");
		selectorEstudios.addItem("Secundario");
		selectorEstudios.addItem("Terciario");
		selectorEstudios.addItem("Universitario");
		add(selectorEstudios);

		add(new Checkbox("Femenino", sexo, true));
		add(new Checkbox("Masculino", sexo, false));

		add(botonAlta);
	}

	public boolean action(Event evento, Object objeto) {
		if (evento.target instanceof Button) {
			if ("Dar de alta al nuevo socio".equals(objeto)) {
				String elApellido = textoApellido.getText();
				String elNombre = textoNombre.getText();
				String laDireccion = textoDireccion.getText();
				String losEstudios = selectorEstudios.getSelectedItem();
				String elSexo = sexo.getSelectedCheckbox().getLabel();

				System.out.println("Los datos del nuevo socio son: ");
				System.out.println("Nombre completo: " + elApellido + ", " + elNombre);
				System.out.println("Direccion: " + laDireccion);
				System.out.println("El nivel de estudios de " + elNombre + " " + elApellido + " es: " + losEstudios);
				System.out.println("Sexo: " + elSexo);
			}
		}
		return true;
	}

}