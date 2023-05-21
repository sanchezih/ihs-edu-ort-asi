package tp1;

/** @modelguid {B072E6A4-AA2F-4520-85EC-DCE25BB51916} */
public class PruebaAB {
	/** @modelguid {D8CD1FAA-A8F3-4168-913C-2A99113EE7AC} */
	public static void main(String[] args) {
		PruebaAB pab = new PruebaAB();
		pab.prueba5();
		// pab.prueba1();

	}

	/** @modelguid {5DCC11E1-8539-450B-ACBC-618A8310E865} */
	public void prueba1() {
		A a = new A();
		a.set(10, 20);
		a.print(); // 10 20
		a.incx();
		a.print(); // 11 20
	}

	/** @modelguid {C865CB0C-AA72-49A9-AA05-B46AA843753E} */
	public void prueba2() {
		// a.incx(); // Ok
		// a.x(); // Ok
		// a.incz(); // error, incz no está definido para A
	}

	/** @modelguid {5ACE9733-F4D3-4F99-963C-E17BE827F19C} */
	public void prueba3() {
		A a = new B(); // Ok
	}

	/** @modelguid {97DA4AB5-2CD1-4EEC-9483-3609001D013E} */
	public void prueba4() {
		A a = new B();
		B b = (B) a;
		b.incz(); // Ok
		((B) a).incz(); // Ok
		b.print();

	}

	/** @modelguid {E3605FE8-1E35-44F7-B7AF-1A219E2FE32A} */
	public void prueba5() {
		A a = new A();
		B b = (B) a; // Ok, en compilación, pero error en tiempo de ejecución
	}

	/** @modelguid {158F9C2C-7E4E-4E77-9AED-03775FE5C9FF} */
	public void prueba6() {
		class A

		{
			// A(int ix, int iy){ ... };
		}

		class B extends A {
		}
//B b= new B(1,2); // error, ningún constructor calza
	}

	/** @modelguid {1C8CB9CF-6577-47FD-91F1-381A568ADEE1} */
	public void prueba7() {
	}

	/** @modelguid {6B4A88BF-9ABF-46A5-BB48-9431A26C7C3D} */
	public void prueba8() {
	}

	/** @modelguid {2D770324-4A26-4B1F-AD69-3BB68AAF4534} */
	public void prueba9() {
	}

	/** @modelguid {C6FC5E30-8D3A-45FD-8D0F-FE43BDFF9726} */
	public void prueba10() {
	}

	/** @modelguid {E796EA85-F094-49C9-81E6-783CFF023E2E} */
	public void prueba11() {
	}

	/** @modelguid {6B2ACCCF-BB53-4038-B6C9-8E3E89B27E5D} */
	public void prueba12() {
	}

}