package tp1;

class B extends A {

	// variables que B agrega a A
	public int z;

	// Metodos que B agrega a A
	// Observe que B tambien posee x
	public void incz() {
		z = z + x;
	}
}