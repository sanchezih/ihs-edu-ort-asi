package labII_U2_herencia_III;

public class Comida {
	public String color;
	public String nombre;

	// Constructor
	public Comida(String sColor, String sNombre) {
		color = sColor;
		nombre = sNombre;
	}

	// Metodos
	public String getColor() {
		return color;
	}

	public String getNombre() {
		return nombre;
	}

	public void setColor(String aColor) {
		color = aColor;
	}

	public void setNombre(String aNombre) {
		nombre = aNombre;
	}

	public Comida() {
	}

}
