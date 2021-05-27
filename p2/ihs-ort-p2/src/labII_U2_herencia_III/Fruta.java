package labII_U2_herencia_III;

public class Fruta extends Comida {
	public String dulzor;
	public String estacion;

	public String getDulzor() {
		return dulzor;
	}

	public void setDulzor(String aDulzor) {
		dulzor = aDulzor;
	}

	public Fruta(String sNombre, String sColor, String sDulzor, String sEstacion) {
		super(sNombre, sColor);
		dulzor = sDulzor;
		color = sColor;
	}

	public String getEstacion() {
		return estacion;
	}

	public void setEstacion(String aEstacion) {
		estacion = aEstacion;
	}
}
