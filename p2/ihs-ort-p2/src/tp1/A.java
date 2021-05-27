package tp1;

/** @modelguid {46C2D899-1CC6-4374-81E0-377303A20C0D} */
public class A {
	/** @modelguid {71490351-EE72-4358-B1AE-CCAE4968BF4E} */
	public int x;

	/** @modelguid {A222FDE6-7865-45BA-921A-522A27AA5F56} */
	public int y;

	/** @modelguid {D4354978-3F49-4DB6-BDB2-26ADC2DC54F7} */
	public A() {
		x = 0;
		y = 0;
	} // el constructor sin parámetros

	/** @modelguid {B4D99D4A-A59F-498A-B98A-4806A2029740} */
	A(int ix, int iy) {
		x = ix;
		y = iy;
	} // el constructor con parámetros

	/** @modelguid {60FE02FB-99CC-442D-99CD-30CC4CF62956} */
	public void set(int vx, int vy) {
		x = vx;
		y = vy;
	}

	/** @modelguid {290165D6-C5C1-4513-8F8E-60817B6A244B} */
	public void incx() {
		x++;
	}

	/** @modelguid {1785A48A-206D-4D8A-BFE7-3A460E713267} */
	public void print() {
		System.out.println("Valor de X: " + x + " " + "Valor de Y: " + y);
	}

	/** @modelguid {BCAEE7C3-7A0C-45C9-8243-5DBC63CACFB4} */
	public void incy() {
		y++;
	}

}
