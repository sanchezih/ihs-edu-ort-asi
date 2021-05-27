package labII_U2_herencia_III;

public class Cebolla extends Verdura {
	public boolean provocaLagrimas;

	public Cebolla(String sColor, String sNombre, boolean bTuberoso) {
		super(sColor, sNombre, bTuberoso);
		// TODO Auto-generated constructor stub
	}

	public boolean getProvocaLagrimas() {
		return provocaLagrimas;
	}

	public void setProvocaLagrimas(boolean aProvocaLagrimas) {
		provocaLagrimas = aProvocaLagrimas;
	}

}
