package labII_U2_herencia_III;

public class Verdura extends Comida {

	public boolean tuberoso;

	public boolean getTuberoso() {
		/* Begin Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */

		return tuberoso;
		/* End Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */
	}

	// Costructor
	public Verdura(String sColor, String sNombre, boolean bTuberoso) {
		super(sColor, sNombre);
		tuberoso = bTuberoso;
	}

	public void setTuberoso(boolean aTuberoso) {
		/* Begin Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
		tuberoso = aTuberoso;
		/* End Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
	}

}
