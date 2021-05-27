package labII_U2_herencia_III;

/** @modelguid {817950ED-60C6-4082-B89A-A117DE50F9D4} */
public class Platano extends Fruta {
	/** @modelguid {516317F0-D1AA-4CC6-9E6C-16EF295A54C4} */
	public boolean maduro;

	/** @modelguid {742E8790-BD60-4287-86E5-4067E536A559} */
	public boolean getMaduro() {
		/* Begin Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */

		return maduro;
		/* End Template Expansion{9A0448E9-A403-4CE3-8CC6-E5BBB53CCC0E} */
	}

	/** @modelguid {BB3EC1D8-6E7C-4C46-B0D4-58CDB982D2B4} */
	public void setMaduro(boolean aMaduro) {
		/* Begin Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
		maduro = aMaduro;
		/* End Template Expansion{29CE507E-049A-4E76-AB8E-F2371317EEAA} */
	}

	/** @modelguid {EF1844A3-7F57-4762-83B9-6B989B2DA399} */
//   public static void main(String[] args)
//   {
//  	Platano P = new Platano("Amarillo", "Brasilera", "Mucho", "Verano", true);
//    	System.out.println("El Dulzor del Platano es: " + P.getDulzor());
//    }
//
	/** @modelguid {2D16C9F4-00A7-4AAB-B1A3-67ED1AAE56F5} */
	public Platano(String sColor, String sNombre, String sDulzor, String sEstacion, boolean sMaduro) {
		super(sColor, sNombre, sDulzor, sEstacion);
		maduro = sMaduro;
	}

}
