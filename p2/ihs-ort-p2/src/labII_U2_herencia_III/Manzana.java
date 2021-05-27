package labII_U2_herencia_III;

public class Manzana extends Fruta {

	public String paisOrigen;
	public boolean deCocina;

	public Manzana(String sNombre, String sColor, String sDulzor, String sEstacion) {
		super(sNombre, sColor, sDulzor, sEstacion);
		// TODO Auto-generated constructor stub
	}

	public String getPaisOrigen() {
		/* Begin Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */

		return paisOrigen;
		/* End Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */
	}

	public void setPaisOrigen(String aPaisOrigen) {
		/* Begin Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
		paisOrigen = aPaisOrigen;
		/* End Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
	}

	public boolean getDeCocina() {
		/* Begin Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */

		return deCocina;
		/* End Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */
	}

	public void setDeCocina(boolean aDeCocina) {
		/* Begin Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
		deCocina = aDeCocina;
		/* End Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
	}

}
